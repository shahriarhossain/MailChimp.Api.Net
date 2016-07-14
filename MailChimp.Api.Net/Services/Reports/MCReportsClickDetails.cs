using System;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Reports
{
    // ============================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Get detailed information about links clicked in campaigns. 
    // ============================================================================

    internal class MCReportsClickDetails
    {
        /// <summary>
        /// Return detailed information about links clicked in campaigns.
        /// <param name="campaignId">Campaign Id</param>
        /// </summary>
        internal async Task<ClickReports> GetClickDetailsAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.click_details, SubTargetType.not_applicable, campaignId);

            return await BaseOperation.GetAsync<ClickReports>(endpoint);
        }

        /// <summary>
        /// Return click details for a specific link
        /// <param name="campaignId">Campaign Id</param>
        /// <param name="linkId">The id for the link.</param>
        /// </summary>
        internal async Task<ClickReports> GetLinkSpecificClickDetailsAsync(string campaignId, string linkId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.click_details, SubTargetType.not_applicable, campaignId, linkId);

            return await BaseOperation.GetAsync<ClickReports>(endpoint);
        }

        /// <summary>
        /// Return click details for a specific link
        /// <param name="campaignId">Campaign Id</param>
        /// <param name="linkId">The id for the link</param>
        /// </summary>
        internal async Task<ClickReports> GetAlllSubscribersInfoAsync(string campaignId, string linkId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.click_details, SubTargetType.members, campaignId, linkId);

            return await BaseOperation.GetAsync<ClickReports>(endpoint);
        }

        /// <summary>
        /// Return click details for a specific link
        /// <param name="campaignId">Campaign Id</param>
        /// <param name="linkId">The id for the link</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
        /// </summary>
        internal async Task<ClickReports> GetSpecificSubscriberInfoAsync(string campaignId, string linkId, string subscriber_hash)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.click_details, SubTargetType.members, campaignId, linkId);
            endpoint = String.Format("{0}/{1}", endpoint, subscriber_hash);

            return await BaseOperation.GetAsync<ClickReports>(endpoint);
        }
    }
}
