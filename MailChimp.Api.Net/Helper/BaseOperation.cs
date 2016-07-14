using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Services;
using Newtonsoft.Json;
using MailChimp.Api.Net.Domain;
using Newtonsoft.Json.Converters;

namespace MailChimp.Api.Net.Helper
{
    // =================================================================================================
    // AUTHOR      : Shahriar Hossain, Microsoft Azure MVP
    // PURPOSE     : Perform core operation
    // =================================================================================================

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
                        NullValueHandling = NullValueHandling.Ignore,

                        Converters = new List<JsonConverter> 
                        { 
                            new IsoDateTimeConverter()
                            {
                                DateTimeFormat= "yyyy-MM-dd HH:mm:ss"
                            },
                            new StringEnumConverter()
                        }
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
        
        /// <summary>
        /// Create something
        /// <param name="endpoint">The url where we want to hit to get result</param>
        /// </summary>
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
                      NullValueHandling = NullValueHandling.Ignore,
                      Converters = new List<JsonConverter> 
                        { 
                            new StringEnumConverter()
                        }
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
                      NullValueHandling = NullValueHandling.Ignore,
                      Converters = new List<JsonConverter> 
                        { 
                            new StringEnumConverter()
                        }
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
        
        /// <summary>
        /// Patch something
        /// <param name="endpoint">The url where we want to hit to get result</param>
        /// <param name="myContent">The content that you want to send</param>
        /// </summary>
        public static async Task<ResultWrapper<T>>
          PatchAsync<T>(string endpoint, T myContent) where T : class
        {
            ResultWrapper<T> wrapper;

            using (var client = new HttpClient())
            {
                try
                {
                    Authenticate.ClientAuthentication(client);

                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,

                        Converters = new List<JsonConverter> 
                        { 
                            new IsoDateTimeConverter()
                            {
                                DateTimeFormat= "yyyy-MM-dd HH:mm:ss"
                            },
                            new StringEnumConverter()
                        }

                    };

                    var myContentJson = JsonConvert.SerializeObject(myContent, settings);

                    Uri uri = new Uri(endpoint);
                    HttpContent content = new StringContent(myContentJson.ToString(), Encoding.UTF8, "application/json");

                    var response = await HttpClientExtensions.PatchAsync(client, uri, content);

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

    /// <summary>
    /// Static class for HTTP-Patch method missing in System.Net.Http
    /// </summary>
    public static class HttpClientExtensions
    {
        /// <summary>
        /// Patch something
        /// <param name="client">System.Net.Http.HttpClient client</param>
        /// <param name="requestUri">System.Uri requestUri</param>
        /// <param name="iContent">System.Net.HttpContent iContent</param>
        /// <param name="httpMethod">System.Net.Http.HttpMethod httpMethod</param>
        /// </summary>
        public static async Task<HttpResponseMessage> PatchAsync(HttpClient client, Uri requestUri, HttpContent iContent, string httpMethod = "PATCH")
        {
            HttpMethod method = new HttpMethod(httpMethod);  
          
            var request = new HttpRequestMessage(method, requestUri)
            {
                Content = iContent
            };

            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                client.DefaultRequestHeaders.ExpectContinue = false;
                response = await client.SendAsync(request);
            }
            catch (TaskCanceledException ex)
            {
                throw ex;
            }
            return response;
        }
    }

}
