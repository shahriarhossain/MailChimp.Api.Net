using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Reports
{
    // ============================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Get recent feedback based on a campaign’s statistics. 
    // ============================================================================

    internal class MCReportsCampaignAdvice
    {
        /// <summary>
        /// Return recent feedback based on a campaign’s statistics
        /// <param name="campaignId">Campaign Id</param>
        /// </summary>
        internal async Task<CampaignAdvice> GetAdviceAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.advice, SubTargetType.not_applicable, campaignId);

            return await BaseOperation.GetAsync<CampaignAdvice>(endpoint);
        }

    }
}
