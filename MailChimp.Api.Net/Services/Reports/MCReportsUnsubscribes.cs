using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Reports
{
    // ===========================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Get information about list members who unsubscribed from a specific campaign
    // ===========================================================================================

    internal class MCReportsUnsubscribes
    {
        /// <summary>
        /// Return statistics for the top-performing domains from a campaign.
        /// <param name="campaignId">Unique id for campaign</param>
        /// </summary>
        internal async Task<RootUnsubscribe> GetUnsubscriberListAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.unsubscribed, SubTargetType.not_applicable, campaignId);

            return await BaseOperation.GetAsync<RootUnsubscribe>(endpoint);
        }

        /// <summary>
        /// Return top open locations for a specific campaign.
        /// <param name="campaignId">Unique id for the campaign</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
        /// </summary>
        internal async Task<SentTo> GetUnsubscriberInfoAsync(string campaignId, string subscriber_hash)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.unsubscribed, SubTargetType.not_applicable, campaignId, subscriber_hash);

            return await BaseOperation.GetAsync<SentTo>(endpoint);
        }
    }
}
