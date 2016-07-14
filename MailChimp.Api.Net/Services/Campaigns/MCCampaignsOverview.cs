using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Campaigns;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Campaigns
{
    // ==================================================================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Campaigns are how you send emails to your MailChimp list. Use the Campaigns API calls to manage campaigns in your MailChimp account.
    // ===================================================================================================================================================
    internal class MCCampaignsOverview
    {
        /// <summary>
        /// Get all campaigns
        /// </summary>
        internal async Task<RootCampaign> GetCampaignsAsync()
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.not_applicable, SubTargetType.not_applicable);

            return await BaseOperation.GetAsync<RootCampaign>(endpoint);
        }

        /// <summary>
        /// Get information about a specific campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        internal async Task<Campaign> GetCampaignByIdAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.not_applicable, SubTargetType.not_applicable, campaignId);

            return await BaseOperation.GetAsync<Campaign>(endpoint);
        }

        /// <summary>
        /// Delete a campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        internal async Task<HttpResponseMessage> DeleteCampaignByIdAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.not_applicable, SubTargetType.not_applicable, campaignId);

            return await BaseOperation.DeleteAsync(endpoint);
        }


        /// <summary>
        /// Create a new campaign
        /// <param name="campaignType">Possible Value : regular, plaintext, absplit, rss, variate </param>
        /// <param name="CampaignRecipient"></param>
        /// <param name="campaignTracking"></param>
        /// <param name="campaignTracking"></param>
        /// </summary>
        internal async Task<dynamic> CreateCampaignAsync(CampaignType campaignType, 
                                                                    Recipients CampaignRecipient, 
                                                                    Settings campaignSettings,
                                                                    Tracking campaignTracking )
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.not_applicable, SubTargetType.not_applicable);

            Campaign campaignObject = new Campaign()
            {
                type = campaignType.ToString(),
                recipients = CampaignRecipient,
                settings= campaignSettings,
                tracking= campaignTracking
            };

            return await BaseOperation.PostAsync<Campaign>(endpoint, campaignObject);
        }


        /// <summary>
        /// Cancel a campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        internal async Task<dynamic> CancelCampaignAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.action3, SubTargetType.not_applicable, campaignId);

            return await BaseOperation.PostAsync(endpoint);
        }

        /// <summary>
        /// Send a campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        internal async Task<dynamic> SendCampaignAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.action6, SubTargetType.not_applicable, campaignId);

            return await BaseOperation.PostAsync(endpoint);
        }

    }
}
