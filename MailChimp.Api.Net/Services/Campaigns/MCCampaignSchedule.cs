using System;
using System.Threading.Tasks;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;
using MailChimp.Api.Net.Domain.Campaigns;

namespace MailChimp.Api.Net.Services.Campaigns
{
    // ==============================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Schedule Campaign blast time
    // ==============================================

    internal class MCCampaignSchedule
    {
        /// <summary>
        /// Schedule Campaign Blast time
        /// <param name="campaignId">Unique id for the campaign</param>
        /// <param name="dateTime">Schedule time in UTC format</param>
        /// </summary>
        internal async Task<dynamic> ScheduleCampaignAsync(string campaignId, DateTime dateTime)
        {
            string endpoint = Authenticate.LegacyEndPoint(TargetTypes.campaigns, SubTargetType.schedule);

            Schedule content = new Schedule()
            {
                apikey = Authenticate.FeatchApiKey(),
                cid = campaignId,
                schedule_time = dateTime               
            };

            return await BaseOperation.PostAsync<Schedule>(endpoint, content);
        }
    }
}
