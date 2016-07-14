using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Lists;
using MailChimp.Api.Net.Enum;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Lists
{
    // =========================================================================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Manage abuse complaints for a specific list. An abuse complaint occurs when your recipient reports an email as spam in their mail program.
    // =========================================================================================================================================================

    internal class MCListsAbuseReports
    {
        /// <summary>
        /// Get information about abuse reports
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        internal async Task<RootAbuseReport> GetAbuseReportsAsync(string list_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.abuse_reports, SubTargetType.not_applicable, list_id);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<RootAbuseReport>(content);
        }


        /// <summary>
        /// Get details about a specific abuse report
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="report_id">Id for the abuse report</param>
        /// </summary>
        internal async Task<AbuseReport> GetSpecificAbuseReportAsync(string list_id, string report_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.abuse_reports, SubTargetType.not_applicable, list_id, report_id);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<AbuseReport>(content);
        }

    }
}
