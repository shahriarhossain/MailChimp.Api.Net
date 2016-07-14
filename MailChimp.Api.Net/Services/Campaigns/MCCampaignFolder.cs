using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.CampaignFolder;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Campaigns
{
    // =====================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Organize your campaigns using folders
    // =====================================================

    internal class MCCampaignFolder
    {
        /// <summary>
        /// Get all campaign folders
        /// </summary>
        internal async Task<RootCampaignFolder> GetCampaignAllFolderAsync()
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaign_folders, SubTargetType.not_applicable, SubTargetType.not_applicable);

            return await BaseOperation.GetAsync<RootCampaignFolder>(endpoint);
        }

        /// <summary>
        /// Get a specific campaign folder
        /// <param name="folder_id">Unique id for the campaign folder</param>
        /// </summary>
        internal async Task<CampaignFolder> GetSpecificCampaignFolderAsync(string folder_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaign_folders, SubTargetType.not_applicable, SubTargetType.not_applicable, folder_id);

            return await BaseOperation.GetAsync<CampaignFolder>(endpoint);
        }

        /// <summary>
        /// Delete a campaign folder
        /// <param name="folder_id">Unique id for the campaign folder</param>
        /// </summary>
        internal async Task<HttpResponseMessage> DeleteSpecificCampaignFolderAsync(string folder_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaign_folders, SubTargetType.not_applicable, SubTargetType.not_applicable, folder_id);

            return await BaseOperation.DeleteAsync(endpoint);
        }

    }
}
