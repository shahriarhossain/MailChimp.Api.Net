using System.Threading.Tasks;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Domain.Reports;
using MailChimp.Api.Net.Helper;

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
        /// </summary>
        internal async Task<ReportOverview> OverviewAsync()
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.not_applicable, SubTargetType.not_applicable);

            return await BaseOperation.GetAsync<ReportOverview>(endpoint);
        }

        /// <summary>
        /// Get a specific campaign report
        /// <param name="campaignId">Campaign Id</param>
        /// </summary>
        internal async Task<ReportOverview_CampaignSpecific> CampaignSpecificOverviewAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.not_applicable, SubTargetType.not_applicable, campaignId);

            return await BaseOperation.GetAsync<ReportOverview_CampaignSpecific>(endpoint);
        }
    }
}
