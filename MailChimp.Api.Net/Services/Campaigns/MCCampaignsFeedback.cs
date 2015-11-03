using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Feedback;
using MailChimp.Api.Net.Enum;
using Newtonsoft.Json;

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

            return JsonConvert.DeserializeObject<RootFeedback>(content);
        }

        /// <summary>
        /// Get feedback about a campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// <param name="feedback_id">Unique id for the feedback message.</param>
        /// </summary>
        internal async Task<Feedback> GetSpecificFeedbackAsync(string campaignId, string feedback_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.feedback, SubTargetType.not_applicable, campaignId, feedback_id);

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

            return JsonConvert.DeserializeObject<Feedback>(content);
        }

        /// <summary>
        /// Delete a campaign feedback message
        /// <param name="campaignId">Unique id for the campaign</param>
        /// <param name="feedback_id">Unique id for the feedback message.</param>
        /// </summary>
        internal async Task<HttpResponseMessage> DeleteSpecificFeedbackAsync(string campaignId, string feedback_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.feedback, SubTargetType.not_applicable, campaignId, feedback_id);

            HttpResponseMessage result;
            using (var client = new HttpClient())
            {
                try
                {
                    Authenticate.ClientAuthentication(client);

                    result = await client.DeleteAsync(endpoint).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    
                    throw ex;
                }
            }

            return result;
        }
    }
}
