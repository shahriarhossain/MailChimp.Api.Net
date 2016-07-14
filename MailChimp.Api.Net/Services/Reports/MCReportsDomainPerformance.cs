using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Reports
{
    // ============================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Get statistics for the top-performing domains from a campaign. 
    // ============================================================================

    internal class MCReportsDomainPerformance
    {
        /// <summary>
        /// Return statistics for the top-performing domains from a campaign.
        /// <param name="campaignId">Unique id for campaign</param>
        /// </summary>
        internal async Task<DomainPerformance> GetDomainPerformanceAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.domain_performance, SubTargetType.not_applicable, campaignId);

            return await BaseOperation.GetAsync<DomainPerformance>(endpoint);
        }
    }
}
