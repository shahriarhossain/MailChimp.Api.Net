using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Services;
using Newtonsoft.Json;
using System.Net;
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
        /// <param name="myContent">The content that you want to send</param>
        /// </summary>
        public static async Task<ResultWrapper<T>>
          PostAsync<T>(string endpoint, T myContent) where T : class
        {
            HttpResponseMessage response;

            ResultWrapper<T> wrapper;

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

                        wrapper = new ResultWrapper<T>(responseMapped, false);

                        return wrapper;
                    }
                    else
                    {
                        wrapper = new ResultWrapper<T>(response, true);

                        return wrapper;
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        //<summary>
        //Create something
        //<param name="endpoint">The url where we want to hit to get result</param>
        //</summary>
        public static async Task<ResultWrapper> PostAsync(string endpoint)
        {
            HttpResponseMessage response;

            using (var client = new HttpClient())
            {
                try
                {
                    Authenticate.ClientAuthentication(client);

                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    };

                    response = await client.PostAsync(endpoint,
                                   new StringContent(String.Empty,
                                   Encoding.UTF8, "application/json"));

                    if (response.IsSuccessStatusCode == true)
                    {
                        return new ResultWrapper(false);
                    }
                    else
                    {
                        var wrappedResult =  new ResultWrapper(response, true);

                        return wrappedResult;
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        /// <summary>
        /// Put something
        /// <param name="endpoint">The url where we want to hit to get result</param>
        /// <param name="myContent">The content that you want to send</param>
        /// </summary>
        public static async Task<ResultWrapper<T>>
          PutAsync<T>(string endpoint, T myContent) where T : class
        {
            HttpResponseMessage response;

            ResultWrapper<T> wrapper;

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

                    response = await client.PutAsync(endpoint,
                                   new StringContent(myContentJson.ToString(),
                                   Encoding.UTF8, "application/json"));

                    if (response.IsSuccessStatusCode == true)
                    {
                        var responseContent = response.Content.ReadAsStringAsync();

                        var responseMapped = JsonConvert.DeserializeObject<T>(responseContent.Result);

                        wrapper = new ResultWrapper<T>(responseMapped, false);

                        return wrapper;
                    }
                    else
                    {
                        wrapper = new ResultWrapper<T>(response, true);

                        return wrapper;
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