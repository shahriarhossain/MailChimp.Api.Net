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
    public class MCReportsLocation
    {
        /// <summary>
        /// Return top open locations for a specific campaign.
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        public async Task<RootLocation> GetTopLocation(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.locations, SubTargetType.not_applicable, campaignId);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint);
            }

            return JsonConvert.DeserializeObject<RootLocation>(content);
        }
    }

}
