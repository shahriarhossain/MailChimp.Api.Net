using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        /// Get information about a specific campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        internal async Task<RootCheckList> GetCampaignContentAsync(string campaign_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.send_checklist, SubTargetType.not_applicable, campaign_id);

            return await BaseOperation.GetAsync<RootCheckList>(endpoint);
        }

    }
}
