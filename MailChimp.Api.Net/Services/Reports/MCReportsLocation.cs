using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Reports
{
    // =============================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Get top open locations for a specific campaign 
    // =============================================================


    internal class MCReportsLocation
    {
        /// <summary>
        /// Return top open locations for a specific campaign.
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        internal async Task<RootLocation> GetTopLocationAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.locations, SubTargetType.not_applicable, campaignId);

            return await BaseOperation.GetAsync<RootLocation>(endpoint);
        }
    }

}
