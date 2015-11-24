using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Campaigns;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Campaigns
{
    // =============================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Manage the HTML, plain-text, and template content for your MailChimp campaigns
    // =============================================================================================

    internal class MCCampaignContent
    {
         ///<summary>
         ///Get campaign content
         ///</summary>
        
        internal async Task<RootContent> GetCampaignContentAsync(string campaign_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.content, SubTargetType.not_applicable, campaign_id);

            return await BaseOperation.GetAsync<RootContent>(endpoint);
        }

    }
}
