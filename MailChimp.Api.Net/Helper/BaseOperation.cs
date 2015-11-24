using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Services;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Helper
{
    internal static class BaseOperation
    {
        /// <summary>
        /// Get some result 
        /// <param name="endpoint">The url where we want to hit to get result</param>
        /// </summary>
        public static async Task<T> GetAsync<T>(string endpoint) where T:class
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

                    result = await client.DeleteAsync(endpoint).ConfigureAwait(false);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            return result;
        }

    }
}
