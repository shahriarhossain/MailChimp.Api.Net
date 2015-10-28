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
    public class MCReportsSubReport
    {
        /// <summary>
        /// Return A list of reports for child campaigns of a specific parent campaign. 
        /// <param name="campaignId">Campaign Id</param>
        /// </summary>
        public async Task<Sub_Reports> GetDomainPerformanceAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.sub_reports, campaignId);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint);
            }

            return JsonConvert.DeserializeObject<Sub_Reports>(content);
        }
    }
}
