using System;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Campaigns;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Campaigns
{
    // =================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Review the send checklist for your campaign, and resolve any issues before sending
    // =================================================================================================

    internal class MCCampaignsCheckList
    {
        /// <summary>
        /// Get the send checklist for a campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        [Obsolete("MethodName is misleading, USE GetCheckListAsync() instead.")]
        internal async Task<RootCheckList> GetCampaignContentAsync(string campaign_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.send_checklist, SubTargetType.not_applicable, campaign_id);

            return await BaseOperation.GetAsync<RootCheckList>(endpoint);
        }


        /// <summary>
        /// Get the send checklist for a campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        internal async Task<RootCheckList> GetCheckListAsync(string campaign_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.send_checklist, SubTargetType.not_applicable, campaign_id);

            return await BaseOperation.GetAsync<RootCheckList>(endpoint);
        }

    }
}
