using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Reports
{
    // =====================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Get details about campaign recipients
    // =====================================================

    internal class MCReportsSentTo
    {
        /// <summary>
        /// Return top open locations for a specific campaign.
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        internal async Task<RootSentTo> GetRecipientsInfoAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.sent_to, SubTargetType.not_applicable, campaignId);

            return await BaseOperation.GetAsync<RootSentTo>(endpoint);
        }

        /// <summary>
        /// Return top open locations for a specific campaign.
        /// <param name="campaignId">Unique id for the campaign</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
        /// </summary>
        internal async Task<SentTo> GetSpecificCampaignRecipientAsync(string campaignId, string subscriber_hash)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.sent_to, SubTargetType.not_applicable, campaignId, subscriber_hash);

            return await BaseOperation.GetAsync<SentTo>(endpoint);
        }
    }
}
