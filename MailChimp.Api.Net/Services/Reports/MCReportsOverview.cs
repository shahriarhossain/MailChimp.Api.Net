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
    // ==================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Manage campaign reports for your MailChimp account. 
    // ==================================================================

    internal class MCReportsOverview
    {
        /// <summary>
        /// Get campaign reports
        /// <param name="campaignId">Campaign Id</param>
        /// </summary>
        internal async Task<ReportOverview> OverviewAsync()
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.not_applicable, SubTargetType.not_applicable);

            //string content = MailChimpWorker.Execute(Method.Get, endpoint).Result;
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

            return JsonConvert.DeserializeObject<ReportOverview>(content);
        }

        /// <summary>
        /// Get a specific campaign report
        /// <param name="campaignId">Campaign Id</param>
        /// </summary>
        internal async Task<ReportOverview_CampaignSpecific> CampaignSpecificOverviewAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.not_applicable, SubTargetType.not_applicable, campaignId);
          
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
            return JsonConvert.DeserializeObject<ReportOverview_CampaignSpecific>(content);
        }
    }
}
