using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Services.Reports
{
    public class ReportsOverview
    {
        public ReportOverview OverviewAsync()
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports);

            string content = MailChimpWorker.Execute(Method.Get, endpoint).Result;

            return JsonConvert.DeserializeObject<ReportOverview>(content);
        }

        public async Task<ReportOverview_CampaignSpecific> CampaignSpecificOverviewAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, campaignId);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint);
            }

            return JsonConvert.DeserializeObject<ReportOverview_CampaignSpecific>(content);
        }
    }
}
