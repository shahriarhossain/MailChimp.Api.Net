using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Lists;
using MailChimp.Api.Net.Enum;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Lists
{
    // =================================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Get information about the most popular email clients for subscribers in a specific MailChimp list.
    // =================================================================================================================

    internal class MCListsClient
    {
        /// <summary>
        /// Get top email clients
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        internal async Task<RootListsClient> GetTopEmailClientsAsync(string list_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.clients, SubTargetType.not_applicable, list_id);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<RootListsClient>(content);
        }
    }
}
