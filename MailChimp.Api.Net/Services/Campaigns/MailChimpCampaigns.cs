using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.CampaignFolder;
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
    private MCCampaignFolder campaignFolder;

    public MailChimpCampaigns()
    {
      overview = new MCCampaignsOverview();
      campaignContent = new MCCampaignContent();
      feedback = new MCCampaignsFeedback();
      checkList = new MCCampaignsCheckList();
      scheduleCampaign = new MCCampaignSchedule();
      campaignFolder = new MCCampaignFolder();
    }

    #region overview

    /// <summary>
    /// Create a new campaign
    /// <param name="type">Possible Value : regular, plaintext, absplit, rss, variate </param>
    /// <param name="recipients">List settings for the campaign.</param>
    /// <param name="settings">The settings for your campaign, including subject, from name, reply-to address, and more.</param>
    /// <param name="tracking">The tracking options for a campaign.</param>
    /// </summary>
    public async Task<dynamic> CreateCampaignAsync(CampaignType type,
                                              Recipients recipients,
                                              Settings settings,
                                              Tracking tracking)
    {
      return await overview.CreateCampaignAsync(type, recipients, settings, tracking);
    }

    /// <summary>
    /// Update some or all of the settings for a specific campaign.
    /// <param name="campaign_id">A string that uniquely identifies this campaign.</param>
    /// <param name="recipients">List settings for the campaign.</param>
    /// <param name="settings">The settings for your campaign, including subject, from name, reply-to address, and more.</param>
    /// <param name="tracking">The tracking options for a campaign.</param>
    /// </summary>
    public async Task<dynamic> UpdateCampaignAsync(string campaign_id,
                                              Recipients recipients,
                                              Settings settings,
                                              Tracking tracking)
    {
      return await overview.UpdateCampaignAsync(campaign_id,  recipients, settings, tracking);
    }
    
    /// <summary>
    /// Get all campaigns
    /// </summary>
    public async Task<RootCampaign> GetAllCampaignsAsync()
    {
      return await overview.GetAllCampaignsAsync();
    }

    /// <summary>
    /// Get information about a specific campaign
    /// <param name="campaignId">Unique id for the campaign</param>
    /// </summary>
    public async Task<Campaign> GetCampaignAsync(string campaignId)
    {
      return await overview.GetCampaignAsync(campaignId);
    }

    /// <summary>
    /// Delete a campaign
    /// <param name="campaignId">Unique id for the campaign</param>
    /// </summary>
    public async Task<HttpResponseMessage> DeleteCampaignAsync(string campaignId)
    {
      return await overview.DeleteCampaignAsync(campaignId);
    }

    /// <summary>
    /// Cancel a campaign
    /// <param name="campaignId">Unique id for the campaign</param>
    /// </summary>
    public async Task<HttpResponseMessage> CancelCampaignAsync(string campaignId)
    {
      return await overview.CancelCampaignAsync(campaignId);
    }

    /// <summary>
    /// Send Test campaign email
    /// <param name="campaignId">Unique id for the campaign</param>
    /// <param name="test_emails">An array of email addresses to send to</param>
    /// <param name="send_type">The type of test email to send.</param>
    /// </summary>
    public async Task<HttpResponseMessage> TestCampaignAsync(string campaignId, List<string> test_emails, SendType send_type)
    {
      return await overview.TestCampaignAsync(campaignId, test_emails, send_type);
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
    public async Task<RootContent> GetCampaignContentAsync(string campaign_id)
    {
      return await campaignContent.GetCampaignContentAsync(campaign_id);
    }

    ///<summary>
    ///Set campaign content
    ///</summary>
    [Obsolete("Use other overloaded version of SetCampaignContent()", true)]
    public async Task<dynamic> SetCampaignContentAsync(string campaign_id, ContentSetting setting,
                                                  ContentTemplate contentTemplate)
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
    public async Task<Feedback> GetFeedbackAsync(string campaignId, string feedback_id)
    {
      return await feedback.GetFeedbackAsync(campaignId, feedback_id);
    }

    /// <summary>
    /// Delete a campaign feedback message
    /// <param name="campaignId">Unique id for the campaign</param>
    /// <param name="feedback_id">Unique id for the feedback message.</param>
    /// </summary>
    public async Task<HttpResponseMessage> DeleteFeedbackAsync(string campaignId, string feedback_id)
    {
      return await feedback.DeleteFeedbackAsync(campaignId, feedback_id);
    }

    #endregion feedback

    #region checkList

    /// <summary>
    /// Get the send checklist for a campaign
    /// <param name="campaign_id">Unique id for the campaign</param>
    /// </summary>
    public async Task<RootCheckList> GetCheckListAsync(string campaign_id)
    {
      return await checkList.GetCheckListAsync(campaign_id);
    }

    #endregion checkList

    #region schedule 

    /// <summary>
    /// Schedule Campaign Blast time
    /// <param name="campaign_id">Unique id for the campaign</param>
    /// <param name="dateTime">Schedule time in UTC format</param>
    /// </summary>
    public async Task<dynamic> ScheduleCampaignAsync(string campaign_id, DateTime dateTime)
    {
      return await scheduleCampaign.ScheduleCampaignAsync(campaign_id, dateTime);
    }

    #endregion schedule 

    #region campaign folders
    /// <summary>
    /// Add a new campaign folder
    /// <param name="name">Name to associate with the folder</param>  
    /// </summary>
    public async Task<dynamic> AddCampaignFolderAsync(string name)
    {
      return await campaignFolder.AddCampaignFolderAsync(name);
    }

    /// <summary>
    /// Update a campaign folder
    /// <param name="name">Name to associate with the folder</param> 
    /// <param name="folder_id">The unique id for the campaign folder</param>
    /// </summary>
    public async Task<dynamic> UpdateCampaignFolderAsync(string name, string folder_id)
    {
      return await campaignFolder.UpdateCampaignFolderAsync(name, folder_id);
    }

    /// <summary>
    /// Get all campaign folders
    /// <param name="offset">The number of records from a collection to skip. Iterating over large collections with this parameter can be slow</param>
    /// <param name="count">The number of records to return.</param>
    /// </summary>
    public async Task<dynamic> GetAllCampaignFoldersAsync(int offset = 0, int count = 10)
    {
      return await campaignFolder.GetAllCampaignFoldersAsync();
    }

    /// <summary>
    /// Get a specific campaign folder
    /// <param name="folder_id">The unique id for the campaign folder</param>
    /// </summary>
    public async Task<CampaignFolder> GetCampaignFolderAsync(string folder_id)
    {
      return await campaignFolder.GetCampaignFolderAsync(folder_id);
    }

    /// <summary>
    /// Delete a campaign folder
    /// <param name="folder_id">The unique id for the campaign folder</param>
    /// </summary>
    public async Task<HttpResponseMessage> DeleteCampaignFolderAsync(string folder_id)
    {
      return await campaignFolder.DeleteCampaignFolderAsync(folder_id);
    }
    #endregion

  }
}