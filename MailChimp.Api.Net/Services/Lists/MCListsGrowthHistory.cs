using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Lists;
using MailChimp.Api.Net.Enum;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Lists
{
    // ========================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : View a summary of the month-by-month growth activity for a specific list.
    // ========================================================================================

    internal class MCListsGrowthHistory
    {
        /// <summary>
        /// Get list growth history data
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        internal async Task<RootListsGrowthHistory> GetGrowthHistoryAsync(string list_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.growth_history, SubTargetType.not_applicable, list_id);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<RootListsGrowthHistory>(content);
        }

        /// <summary>
        /// Get list growth history by month
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="month">A specific month of list growth history.</param>
        /// </summary>
        internal async Task<RootListsGrowth> GetGrowthHistoryByMonthAsync(string list_id, string month)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.growth_history, SubTargetType.not_applicable, list_id, month);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<RootListsGrowth>(content);
        }
    }
}
