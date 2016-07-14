using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Reports
{
    // ===========================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Get list of reports for child campaigns of a specific parent campaign. 
    // ===========================================================================================

    internal class MCReportsSubReport
    {
        /// <summary>
        /// Return A list of reports for child campaigns of a specific parent campaign. 
        /// <param name="campaignId">Campaign Id</param>
        /// </summary>
        internal async Task<Sub_Reports> GetReportForChildCampaignAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.sub_reports, SubTargetType.not_applicable, campaignId);

            return await BaseOperation.GetAsync<Sub_Reports>(endpoint);
        }
    }
}
