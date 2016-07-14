using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Feedback;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Campaigns
{
    // ==================================================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Post comments, reply to team feedback, and send test emails while you’re working together on a MailChimp campaign.
    // ==================================================================================================================================
    internal class MCCampaignsFeedback
    {
        /// <summary>
        /// Get feedback about a campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        internal async Task<RootFeedback> GetCampaignFeedbackAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.feedback, SubTargetType.not_applicable, campaignId);

            return await BaseOperation.GetAsync<RootFeedback>(endpoint);
        }

        /// <summary>
        /// Get feedback about a campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// <param name="feedback_id">Unique id for the feedback message.</param>
        /// </summary>
        internal async Task<Feedback> GetSpecificFeedbackAsync(string campaignId, string feedback_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.feedback, SubTargetType.not_applicable, campaignId, feedback_id);

            return await BaseOperation.GetAsync<Feedback>(endpoint);
        }

        /// <summary>
        /// Delete a campaign feedback message
        /// <param name="campaignId">Unique id for the campaign</param>
        /// <param name="feedback_id">Unique id for the feedback message.</param>
        /// </summary>
        internal async Task<HttpResponseMessage> DeleteSpecificFeedbackAsync(string campaignId, string feedback_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.feedback, SubTargetType.not_applicable, campaignId, feedback_id);

            return await BaseOperation.DeleteAsync(endpoint);
        }
    }
}
