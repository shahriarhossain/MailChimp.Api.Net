using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Campaigns;

namespace MailChimp.Api.Net.Services.Campaigns
{
    // ==================================================================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Campaigns are how you send emails to your MailChimp list. Use the Campaigns API calls to manage campaigns in your MailChimp account.
    // ===================================================================================================================================================
    public class MailChimpCampaigns
    {
        private MCCampaignsOverview overview;
        private MCCampaignsFeedback feedback;
        public MailChimpCampaigns()
        {
            overview = new MCCampaignsOverview();
            feedback = new MCCampaignsFeedback();
        }
        
        /// <summary>
        /// Get all campaigns
        /// </summary>
        public async Task<RootCampaign> GetCampaignsAsync()
        {
            return await overview.GetCampaignsAsync();
        }

        /// <summary>
        /// Get information about a specific campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        public async Task<Campaign> GetCampaignByIdAsync(string campaignId)
        {
            return await overview.GetCampaignByIdAsync(campaignId);
        }

        /// <summary>
        /// Delete a campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        public async Task<HttpResponseMessage> DeleteCampaignByIdAsync(string campaignId)
        {
            return await overview.DeleteCampaignByIdAsync(campaignId);
        }

        /// <summary>
        /// Cancel a campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        public async Task<HttpResponseMessage> CancelCampaignByIdAsync(string campaignId)
        {
            return await overview.CancelCampaignByIdAsync(campaignId);
        }


    }
}
