using System;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Campaigns;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

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

        ///<summary>
        ///Set campaign content
        ///</summary>
        [Obsolete("Use other overloaded version of SetCampaignContentAsync()")]
        internal async Task<dynamic> SetCampaignContentAsync(string campaign_id, ContentSetting setting, ContentTemplate contentTemplate)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.content, SubTargetType.not_applicable, campaign_id);

            RootContent content = new RootContent()
            {
                template = contentTemplate,
                plain_text = setting.plain_text,
                html =  setting.html,
                url = setting.url
            };

            return await BaseOperation.PutAsync<RootContent>(endpoint, content);
        }

        ///<summary>
        ///Set campaign content
        ///</summary>
        internal async Task<dynamic> SetCampaignContentAsync(string campaign_id, ContentSetting setting)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.content, SubTargetType.not_applicable, campaign_id);

            RootContent content = new RootContent()
            {
                plain_text = setting.plain_text,
                html = setting.html,
                url = setting.url
            };

            return await BaseOperation.PutAsync<RootContent>(endpoint, content);
        }

        ///<summary>
        ///Set campaign content
        ///</summary>
        internal async Task<dynamic> SetCampaignContentAsync(string campaign_id, ContentTemplate contentTemplate)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaigns, SubTargetType.content, SubTargetType.not_applicable, campaign_id);

            RootContent content = new RootContent()
            {
                template = contentTemplate,
            };

            return await BaseOperation.PutAsync<RootContent>(endpoint, content);
        }
    }
}
