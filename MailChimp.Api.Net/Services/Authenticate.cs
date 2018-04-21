﻿using System;
using System.Configuration;
using System.Linq;
using MailChimp.Api.Net.ErrorMessages;
using MailChimp.Api.Net.Enum;
using System.Net.Http;
using System.Net.Http.Headers;
using MailChimp.Api.Net.Mapper;
using MailChimp.Api.Net.CustomException;

namespace MailChimp.Api.Net.Services {
	public interface IAPIAuthenticator {

		string FetchApiKey();

		void ClientAuthentication(HttpClient tempClient);

		string LegacyEndPoint(TargetTypes type, SubTargetType subType);

		string EndPoint(TargetTypes type, SubTargetType subType, SubTargetType childSubType, string id = "", string param2 = "");
	}

	public class DefaultAPIConfigAuthenticator : IAPIAuthenticator {
		public string FetchApiKey() {
			try {
				string apiKey = ConfigurationManager.AppSettings["MailChimpApiKey"];
				if (!String.IsNullOrEmpty(apiKey)) {
					return apiKey;
				} else {
					string msg = MailChimpExceptionMessage.NullOrEmptyMessage(CommandProperty.apikey);
					throw new MailChimpExceptions(msg);
				}
			} catch (NullReferenceException ex) {
				string message = "MailChimp API Key missing! To resolve Add a key named \'MailChimpApiKey\' in your config and SET its value with your mailchimp API key!  " + ex.Message ;

				throw new MailChimpExceptions(message);
			} catch (Exception ex) {
				throw new MailChimpExceptions(ex.Message);
			}
		}

		/// <summary>
		/// Get the datacenter prefix based on the API key passed
		/// </summary>
		private string GetDatacenterPrefix() {
			string apikey = FetchApiKey();
			//  The key should contain a '-'
			if (!apikey.Contains('-')) {
				return MailChimpExceptionMessage.InvalidMessage(CommandProperty.apikey);
			}

			return apikey.Split('-')[1];
		}

		/// <summary>
		/// Return the endpoint to caller method
		/// <param name="type">v3.0 Mailchimp EndPoint targetType, example: reports, lists etc</param>
		/// <param name="subType" optional>Expects id for particular list/campaign etc</param>
		/// <param name="id" optional>Expects id for particular list/campaign etc</param>
		/// <param name="linkId" optional>NOT IMPLEMENTED YET</param>
		/// </summary>
		public string EndPoint(TargetTypes type, SubTargetType subType, SubTargetType childSubType, string id = "", string param2 = "") {
			string targetType = EnumMapper.MapTarget(type);
			string subCategory = EnumMapper.Map(subType);
			string subChildCategory = EnumMapper.Map(childSubType);

			var dataCenter = GetDatacenterPrefix();
			if (id != "") {
				if (subCategory != "") {
					if (param2 != "") {
						if (subChildCategory != "") {
							return String.Format("https://{0}.api.mailchimp.com/3.0/{1}/{2}/{3}/{4}/{5}", dataCenter, targetType, id, subCategory, param2, childSubType);
						} else {
							return String.Format("https://{0}.api.mailchimp.com/3.0/{1}/{2}/{3}/{4}", dataCenter, targetType, id, subCategory, param2);
						}
					} else {
						return String.Format("https://{0}.api.mailchimp.com/3.0/{1}/{2}/{3}", dataCenter, targetType, id, subCategory);
					}

				} else {
					return String.Format("https://{0}.api.mailchimp.com/3.0/{1}/{2}", dataCenter, targetType, id);
				}
			} else {
				return String.Format("https://{0}.api.mailchimp.com/3.0/{1}", dataCenter, targetType);
			}
		}


		/// <summary>
		/// Return the endpoint to caller method
		/// <param name="type">v2.0 Mailchimp EndPoint targetType, example: campaign, lists etc</param>
		/// <param name="subType" optional></param>
		/// </summary>
		public string LegacyEndPoint(TargetTypes type, SubTargetType subType) {
			string targetType = EnumMapper.MapTarget(type);

			string subCategory = EnumMapper.Map(subType);

			var dataCenter = GetDatacenterPrefix();

			return String.Format("https://{0}.api.mailchimp.com/2.0/{1}/{2}", dataCenter, targetType, subCategory);
		}


		/// <summary>
		/// Return the endpoint to caller method
		/// <param name="id" optional>Expects id for particular list/campaign etc</param>
		/// </summary>
		public void ClientAuthentication(HttpClient client) {
			//HEADS UP!!!! THIS PORTION NEEDS TO REFACTOR !
			//Method name have to change
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", FetchApiKey());
		}

	}
	internal static class Authenticate {
		private static IAPIAuthenticator _apiAuthenticator = null;
		public static IAPIAuthenticator APIAuthenticator {
			get {
				if (null == _apiAuthenticator) {
					_apiAuthenticator = new DefaultAPIConfigAuthenticator();
				}
				return _apiAuthenticator;
			}
			set {
				_apiAuthenticator = value;
			}
		}

    /// <summary>
		/// Retrieve the API key from App.Config and check if its valid
		/// </summary>
		public static string FetchApiKey() {
			return APIAuthenticator.FetchApiKey();
		}

		/// <summary>
		/// Return the endpoint to caller method
		/// <param name="type">v3.0 Mailchimp EndPoint targetType, example: reports, lists etc</param>
		/// <param name="subType" optional>Expects id for particular list/campaign etc</param>
		/// <param name="id" optional>Expects id for particular list/campaign etc</param>
		/// <param name="linkId" optional>NOT IMPLEMENTED YET</param>
		/// </summary>
		public static string EndPoint(TargetTypes type, SubTargetType subType, SubTargetType childSubType, string id = "", string param2 = "") {
			return APIAuthenticator.EndPoint(type, subType, childSubType, id, param2);
		}

		/// <summary>
		/// Return the endpoint to caller method
		/// <param name="type">v2.0 Mailchimp EndPoint targetType, example: campaign, lists etc</param>
		/// <param name="subType" optional></param>
		/// </summary>
		public static string LegacyEndPoint(TargetTypes type, SubTargetType subType) {
			return APIAuthenticator.LegacyEndPoint(type, subType);
		}

		/// <summary>
		/// Return the endpoint to caller method
		/// <param name="id" optional>Expects id for particular list/campaign etc</param>
		/// </summary>
		public static void ClientAuthentication(HttpClient client) {
			APIAuthenticator.ClientAuthentication(client);
		}

	}
}
