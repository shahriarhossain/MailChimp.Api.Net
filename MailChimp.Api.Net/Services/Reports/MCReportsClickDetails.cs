using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;
using MailChimp.Api.Net.Enum;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Reports
{
    public class MCReportsClickDetails
    {
        /// <summary>
        /// Return detailed information about links clicked in campaigns.
        /// <param name="campaignId">Campaign Id</param>
        /// </summary>
        public async Task<ClickReports> GetClickDetailsAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.click_details, SubTargetType.not_applicable, campaignId);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint);
            }

            return JsonConvert.DeserializeObject<ClickReports>(content);
        }

        /// <summary>
        /// Return click details for a specific link
        /// <param name="campaignId">Campaign Id</param>
        /// <param name="linkId">The id for the link.</param>
        /// </summary>
        public async Task<ClickReports> GetLinkSpecificClickDetailsAsync(string campaignId, string linkId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.click_details, SubTargetType.not_applicable, campaignId, linkId);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint);
            }

            return JsonConvert.DeserializeObject<ClickReports>(content);
        }

        /// <summary>
        /// Return click details for a specific link
        /// <param name="campaignId">Campaign Id</param>
        /// <param name="linkId">The id for the link</param>
        /// </summary>
        public async Task<ClickReports> GetAlllSubscribersInfoAsync(string campaignId, string linkId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.click_details, SubTargetType.members, campaignId, linkId);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint);
            }

            return JsonConvert.DeserializeObject<ClickReports>(content);
        }

        /// <summary>
        /// Return click details for a specific link
        /// <param name="campaignId">Campaign Id</param>
        /// <param name="linkId">The id for the link</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
        /// </summary>
        public async Task<ClickReports> GetSpecificSubscriberInfoAsync(string campaignId, string linkId, string subscriber_hash)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.click_details, SubTargetType.members, campaignId, linkId);
            endpoint = String.Format("{0}/{1}", endpoint, subscriber_hash);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint);
            }

            return JsonConvert.DeserializeObject<ClickReports>(content);
        }
    }
}
