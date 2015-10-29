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
    public class MCReportsEmailActivity
    {
        /// <summary>
        /// Return list member activity for a specific campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        public async Task<EmailActivity> GetEmailActivityAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.email_activity, SubTargetType.not_applicable, campaignId);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint);
            }

            return JsonConvert.DeserializeObject<EmailActivity>(content);
        }

        /// <summary>
        /// Return list member activity for a specific campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
        /// </summary>
        public async Task<EmailActivity> GetSubscriberSpecificEmailActivityAsync(string campaignId, string subscriber_hash)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.email_activity, SubTargetType.not_applicable, campaignId, subscriber_hash);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint);
            }

            return JsonConvert.DeserializeObject<EmailActivity>(content);
        }
    }
}
