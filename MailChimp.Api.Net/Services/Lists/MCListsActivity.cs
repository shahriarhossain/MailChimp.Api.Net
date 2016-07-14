using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Lists;
using MailChimp.Api.Net.Enum;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Lists
{
    // ====================================================================================================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Get recent daily, aggregated activity stats for your list. For example, view unsubscribes, signups, total emails sent, opens, clicks, and more, for up to 180 days.
    // ===================================================================================================================================================================================

    internal class MCListsActivity
    {
        /// <summary>
        /// Get recent list activity
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        internal async Task<RootListsActivity> GetRecentActivityAsync(string list_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.activity, SubTargetType.not_applicable, list_id);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<RootListsActivity>(content);
        }

    }
}
