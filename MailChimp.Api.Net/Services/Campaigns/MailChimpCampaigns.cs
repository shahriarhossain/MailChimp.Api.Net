using System;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Campaigns;
using MailChimp.Api.Net.Domain.Feedback;
using MailChimp.Api.Net.Enum;


namespace MailChimp.Api.Net.Services.Campaigns
{
    // ==================================================================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Campaigns are how you send emails to your MailChimp list. Use the Campaigns API calls to manage campaigns in your MailChimp account.
    // ===================================================================================================================================================
    public class MailChimpCampaigns
    {
        private MCCampaignsOverview overview;
        private MCCampaignContent campaignContent;
        private MCCampaignsFeedback feedback;
        private MCCampaignsCheckList checkList;
        private MCCampaignSchedule scheduleCampaign;
        
        public MailChimpCampaigns()
        {
            overview = new MCCampaignsOverview();
            campaignContent = new MCCampaignContent();
            feedback = new MCCampaignsFeedback();
            checkList = new MCCampaignsCheckList();
            scheduleCampaign = new MCCampaignSchedule();
        }

        #region overview
        /// <summary>
        /// Create a new campaign
        /// <param name="campaignType">Possible Value : regular, plaintext, absplit, rss, variate </param>
        /// <param name="CampaignRecipient"></param>
        /// <param name="campaignTracking"></param>
        /// <param name="campaignTracking"></param>
        /// </summary>
        public async Task<dynamic> CreateCampaignAsync(CampaignType campaignType,
                                                                    Recipients CampaignRecipient,
                                                                    Settings campaignSettings,
                                                                    Tracking campaignTracking)
        {
            return await overview.CreateCampaignAsync(campaignType, CampaignRecipient, campaignSettings, campaignTracking);
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
        public async Task<HttpResponseMessage> DeleteSpecificCampaign(string campaignId)
        {
            return await overview.DeleteCampaignByIdAsync(campaignId);
        }

        /// <summary>
        /// Cancel a campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        public async Task<HttpResponseMessage> CancelCampaignByIdAsync(string campaignId)
        {
            return await overview.CancelCampaignAsync(campaignId);
        }

        /// <summary>
        /// Send a campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        public async Task<dynamic> SendCampaignAsync(string campaignId)
        {
            return await overview.SendCampaignAsync(campaignId);
        }

        #endregion overview

        #region campaignContent
        ///<summary>
        ///Get campaign content
        ///</summary>
        public async Task<RootContent> GetContentAsync(string campaign_id)
        {
            return await campaignContent.GetCampaignContentAsync(campaign_id);
        }

        ///<summary>
        ///Set campaign content
        ///</summary>
        [Obsolete("Use other overloaded version of SetCampaignContentAsync()", true)]
        public async Task<dynamic> SetCampaignContentAsync(string campaign_id, ContentSetting setting, ContentTemplate contentTemplate)
        {
            return await campaignContent.SetCampaignContentAsync(campaign_id, setting, contentTemplate);
        }


        ///<summary>
        ///Set campaign content
        ///</summary>
        public async Task<dynamic> SetCampaignContentAsync(string campaign_id, ContentSetting setting)
        {
            return await campaignContent.SetCampaignContentAsync(campaign_id, setting);
        }

        ///<summary>
        ///Set campaign content
        ///</summary>
        public async Task<dynamic> SetCampaignContentAsync(string campaign_id, ContentTemplate contentTemplate)
        {
            return await campaignContent.SetCampaignContentAsync(campaign_id, contentTemplate);
        }


        #endregion campaignContent

        #region feedback
        /// <summary>
        /// Get feedback about a campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        public async Task<RootFeedback> GetCampaignFeedbackAsync(string campaignId)
        {
            return await feedback.GetCampaignFeedbackAsync(campaignId);
        }

        /// <summary>
        /// Get feedback about a campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// <param name="feedback_id">Unique id for the feedback message.</param>
        /// </summary>
        public async Task<Feedback> GetSpecificFeedbackAsync(string campaignId, string feedback_id)
        {
            return await feedback.GetSpecificFeedbackAsync(campaignId, feedback_id);
        }

         /// <summary>
        /// Delete a campaign feedback message
        /// <param name="campaignId">Unique id for the campaign</param>
        /// <param name="feedback_id">Unique id for the feedback message.</param>
        /// </summary>
        public async Task<HttpResponseMessage> DeleteSpecificFeedbackAsync(string campaignId, string feedback_id)
        {
            return await feedback.DeleteSpecificFeedbackAsync(campaignId, feedback_id);
        }
        #endregion feedback

        #region checkList
        /// <summary>
        /// Get the send checklist for a campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        [Obsolete("MethodName is misleading, USE GetCheckListAsync() instead.")]
        public async Task<RootCheckList> GetCampaignContentAsync(string campaign_id)
        {
            return await checkList.GetCampaignContentAsync(campaign_id);
        }

        /// <summary>
        /// Get the send checklist for a campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        public async Task<RootCheckList> GetCheckListAsync(string campaign_id)
        {
            return await checkList.GetCheckListAsync(campaign_id);
        }
        #endregion checkList

        #region schedule 
        /// <summary>
        /// Schedule Campaign Blast time
        /// <param name="campaignId">Unique id for the campaign</param>
        /// <param name="dateTime">Schedule time in UTC format</param>
        /// </summary>
        public async Task<dynamic> ScheduleCampaignAsync(string campaign_id, DateTime dateTime)
        {
            return await scheduleCampaign.ScheduleCampaignAsync(campaign_id, dateTime);
        }
        #endregion schedule 

    }
}
