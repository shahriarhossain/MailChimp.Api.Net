using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Services.Reports
{
  public class MailChimpReports
  {
    private MCReportsOverview reportOverview;
    private MCReportsCampaignAdvice campaign;
    private MCReportsClickDetails clickDetails;
    private MCReportsDomainPerformance performance;
    private MCReportsEepURL eepUrl;
    private MCReportsEmailActivity emailActivity;
    private MCReportsLocation location;
    private MCReportsSentTo sentTo;
    private MCReportsSubReport subReport;
    private MCReportsUnsubscribes unsubscribe;

    public MailChimpReports()
    {
      reportOverview = new MCReportsOverview();
      campaign = new MCReportsCampaignAdvice();
      clickDetails = new MCReportsClickDetails();
      performance = new MCReportsDomainPerformance();
      eepUrl = new MCReportsEepURL();
      emailActivity = new MCReportsEmailActivity();
      location = new MCReportsLocation();
      sentTo = new MCReportsSentTo();
      subReport = new MCReportsSubReport();
      unsubscribe = new MCReportsUnsubscribes();
    }

    /// <summary>
    /// Get campaign reports
    /// </summary>
    public async Task<ReportOverview> GetOverviewAsync()
    {
      return await reportOverview.GetOverviewAsync();
    }

    /// <summary>
    /// Get a specific campaign report
    /// <param name="campaignId">Campaign Id</param>
    /// </summary>
    public async Task<ReportOverview_Campaign> GetCampaignOverviewAsync(string campaignId)
    {
      return await reportOverview.GetCampaignOverviewAsync(campaignId);
    }

    /// <summary>
    /// Return recent feedback based on a campaign’s statistics
    /// <param name="campaignId">Campaign Id</param>
    /// </summary>
    public async Task<CampaignAdvice> GetAdviceAsync(string campaignId)
    {
      return await campaign.GetAdviceAsync(campaignId);
    }

    /// <summary>
    /// Return detailed information about links clicked in campaigns.
    /// <param name="campaignId">Campaign Id</param>
    /// </summary>
    public async Task<ClickReports> GetClickDetailsAsync(string campaignId)
    {
      return await clickDetails.GetClickDetailsAsync(campaignId);
    }

    /// <summary>
    /// Return click details for a specific link
    /// <param name="campaignId">Campaign Id</param>
    /// <param name="linkId">The id for the link.</param>
    /// </summary>
    public async Task<ClickReports> GetClickDetailsByLinkAsync(string campaignId, string linkId)
    {
      return await clickDetails.GetClickDetailsByLinkAsync(campaignId, linkId);
    }

    /// <summary>
    /// Return click details for a specific link
    /// <param name="campaignId">Campaign Id</param>
    /// <param name="linkId">The id for the link</param>
    /// </summary>
    public async Task<ClickReports> GetAlllSubscribersInfoAsync(string campaignId, string linkId)
    {
      return await clickDetails.GetAllSubscribersInfoAsync(campaignId, linkId);
    }

    /// <summary>
    /// Return click details for a specific link
    /// <param name="campaignId">Campaign Id</param>
    /// <param name="linkId">The id for the link</param>
    /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
    /// </summary>
    public async Task<ClickReports> GetSubscriberInfoAsync(string campaignId, string linkId, string subscriber_hash)
    {
      return await clickDetails.GetSubscriberInfoAsync(campaignId, linkId, subscriber_hash);
    }

    /// <summary>
    /// Return statistics for the top-performing domains from a campaign.
    /// <param name="campaignId">Unique id for campaign</param>
    /// </summary>
    public async Task<DomainPerformance> GetDomainPerformanceAsync(string campaignId)
    {
      return await performance.GetDomainPerformanceAsync(campaignId);
    }

    /// <summary>
    /// Return a summary of social activity for the campaign, tracked by EepURL.
    /// <param name="campaignId">Unique id for campaign</param>
    /// </summary>
    public async Task<Eepurl> GetEepUrlActivityAsync(string campaignId)
    {
      return await eepUrl.GetEepUrlActivityAsync(campaignId);
    }

    /// <summary>
    /// Return list member activity for a specific campaign
    /// <param name="campaignId">Unique id for the campaign</param>
    /// </summary>
    public async Task<EmailActivity> GetEmailActivityAsync(string campaignId)
    {
      return await emailActivity.GetEmailActivityAsync(campaignId);
    }

    /// <summary>
    /// Return list member activity for a specific campaign
    /// <param name="campaignId">Unique id for the campaign</param>
    /// <param name="offset">The number of records from a collection to skip. Iterating over large collections with this parameter can be slow</param>
    /// <param name="count">The number of records to return.</param>
    /// </summary>
    public async Task<EmailActivity> GetEmailActivityAsync(string campaignId, int offset = 0, int count = 10)
    {
      return await emailActivity.GetEmailActivityAsync(campaignId, offset, count);
    }

    /// <summary>
    /// Return list member activity for a specific campaign
    /// <param name="campaignId">Unique id for the campaign</param>
    /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
    /// </summary>
    public async Task<EmailActivity> GetEmailActivityBySubscriberAsync(string campaignId, string subscriber_hash)
    {
      return await emailActivity.GetSubscriberEmailActivityAsync(campaignId, subscriber_hash);
    }

    /// <summary>
    /// Return top open locations for a specific campaign.
    /// <param name="campaignId">Unique id for the campaign</param>
    /// </summary>
    public async Task<RootLocation> GetTopLocationAsync(string campaignId)
    {
      return await location.GetTopLocationAsync(campaignId);
    }

    /// <summary>
    /// Return top open locations for a specific campaign.
    /// <param name="campaignId">Unique id for the campaign</param>
    /// </summary>
    public async Task<RootSentTo> GetRecipientsInfoAsync(string campaignId)
    {
      return await sentTo.GetRecipientsInfoAsync(campaignId);
    }

    /// <summary>
    /// Return top open locations for a specific campaign.
    /// <param name="campaignId">Unique id for the campaign</param>
    /// <param name="offset">The number of records from a collection to skip. Iterating over large collections with this parameter can be slow</param>
    /// <param name="count">The number of records to return.</param>
    /// </summary>
    public async Task<RootSentTo> GetRecipientsInfoAsync(string campaignId, int offset = 0, int count = 10)
    {
      return await sentTo.GetRecipientsInfoAsync(campaignId, offset, count);
    }

    /// <summary>
    /// Return top open locations for a specific campaign.
    /// <param name="campaignId">Unique id for the campaign</param>
    /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
    /// </summary>
    public async Task<SentTo> GetCampaignRecipientAsync(string campaignId, string subscriber_hash)
    {
      return await sentTo.GetCampaignRecipientAsync(campaignId, subscriber_hash);
    }

    /// <summary>
    /// Return A list of reports for child campaigns of a specific parent campaign. 
    /// <param name="campaignId">Campaign Id</param>
    /// </summary>
    public async Task<Sub_Reports> GetReportForChildCampaignAsync(string campaignId)
    {
      return await subReport.GetChildCampaignReportsAsync(campaignId);
    }

    /// <summary>
    /// Return statistics for the top-performing domains from a campaign.
    /// <param name="campaignId">Unique id for campaign</param>
    /// </summary>
    public async Task<RootUnsubscribe> GetUnsubscriberListAsync(string campaignId)
    {
      return await unsubscribe.GetUnsubscriberListAsync(campaignId);
    }

    /// <summary>
    /// Return top open locations for a specific campaign.
    /// <param name="campaignId">Unique id for the campaign</param>
    /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
    /// </summary>
    public async Task<SentTo> GetUnsubscriberInfoAsync(string campaignId, string subscriber_hash)
    {
      return await unsubscribe.GetUnsubscriberInfoAsync(campaignId, subscriber_hash);
    }
  }
}