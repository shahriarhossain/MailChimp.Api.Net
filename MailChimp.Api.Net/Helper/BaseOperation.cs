using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Services;
using Newtonsoft.Json;
using System.Net;
using MailChimp.Api.Net.Domain.Error;
using MailChimp.Api.Net.Domain;

namespace MailChimp.Api.Net.Helper
{
    internal static class BaseOperation
    {
        /// <summary>
        /// Get some result 
        /// <param name="endpoint">The url where we want to hit to get result</param>
        /// </summary>
        public static async Task<T> GetAsync<T>(string endpoint) where T : class
        {
            string content;
            using (var client = new HttpClient())
            {
                try
                {
                    Authenticate.ClientAuthentication(client);

                    content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return JsonConvert.DeserializeObject<T>(content);
        }

        /// <summary>
        /// Delete something
        /// <param name="endpoint">The url where we want to hit to get result</param>
        /// </summary>
        public static async Task<HttpResponseMessage> DeleteAsync(string endpoint)
        {
            HttpResponseMessage result;
            using (var client = new HttpClient())
            {
                try
                {
                    Authenticate.ClientAuthentication(client);

                    result = await client.DeleteAsync(endpoint);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            return result;
        }


        /// <summary>
        /// Create something
        /// <param name="endpoint">The url where we want to hit to get result</param>
        /// </summary>
        public static async Task<dynamic>
            PostAsync<T>(string endpoint, T myContent) where T : class
        {
            HttpResponseMessage response;
            CustomError customeError = new CustomError();

            using (var client = new HttpClient())
            {
                try
                {
                    Authenticate.ClientAuthentication(client);

                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore

                    };

                    var myContentJson = JsonConvert.SerializeObject(myContent, settings);
                    response = await client.PostAsync(endpoint,
                                   new StringContent(myContentJson.ToString(),
                                   Encoding.UTF8, "application/json"));

                    if (response.IsSuccessStatusCode == true)
                    {
                        var responseContent = response.Content.ReadAsStringAsync();

                        var responseMapped = JsonConvert.DeserializeObject<T>(responseContent.Result);

                        //objName.GetType().GetProperty("nameOfProperty").SetValue(objName, objValue, null)
                        responseMapped.GetType().GetProperty("PostStatus").SetValue(responseMapped, true, null);

                        return responseMapped;
                    }
                    else
                    {
                        customeError.ReasonPhrase = response.ReasonPhrase;
                        customeError.RequestMessage = response.RequestMessage;
                        customeError.StatusCode = response.StatusCode;
                        customeError.PostStatus = false;
                        return customeError;
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
