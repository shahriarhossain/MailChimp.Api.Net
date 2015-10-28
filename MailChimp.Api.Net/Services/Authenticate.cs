using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MailChimp.Api.Net.ErrorMessages;
using MailChimp.Api.Net.Enum;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MailChimp.Api.Net.Services
{
    public static class Authenticate
    {
        /// <summary>
        /// Retrieve the API key from App.Config and check if its valid
        /// </summary>
        public static string FeatchApiKey()
        {
            try
            {
                string apiKey = ConfigurationManager.AppSettings["MailChimpApiKey"].ToString();
                if (!String.IsNullOrEmpty(apiKey))
                {
                    return apiKey;
                }
                else
                {
                    return MailChimpExceptionMessage.NullOrEmptyMessage(CommandProperty.apikey);
                }

            }
            catch (Exception ex)
            {
                return MailChimpExceptionMessage.UnknownExceptionMessage(ex);
            }
        }


        /// <summary>
        /// Get the datacenter prefix based on the API key passed
        /// </summary>
        private static string GetDatacenterPrefix()
        {
            string apikey = FeatchApiKey();
            //  The key should contain a '-'
            if (!apikey.Contains('-'))
            {
                return MailChimpExceptionMessage.InvalidMessage(CommandProperty.apikey);
            }

            return apikey.Split('-')[1];
        }


        /// <summary>
        /// Return the endpoint to caller method
        /// <param name="type">v3.0 Mailchimp EndPoint targetType, example: reports, lists etc</param>
        /// <param name="id" optional>Expects id for particular list/campaign etc</param>
        /// </summary>
        public static string EndPoint(TargetTypes type, string id="")
        {
            var dataCenter = GetDatacenterPrefix();
            if (id != "")
            {
                return String.Format("https://{0}.api.mailchimp.com/3.0/{1}/{2}", dataCenter, type, id);
            }
            else
            {
                return String.Format("https://{0}.api.mailchimp.com/3.0/{1}", dataCenter, type);
            }        
        }

        /// <summary>
        /// Return the endpoint to caller method
        /// <param name="id" optional>Expects id for particular list/campaign etc</param>
        /// </summary>
        public static void ClientAuthentication(HttpClient client)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization =
                 new AuthenticationHeaderValue("Basic", Authenticate.FeatchApiKey());  
        }

    }
}
