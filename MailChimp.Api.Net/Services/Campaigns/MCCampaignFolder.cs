using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.CampaignFolder;
using MailChimp.Api.Net.Enum;
using Newtonsoft.Json;

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

            string content;
            using (var client = new HttpClient())
            {
                try
                {
                    Authenticate.ClientAuthentication(client);

                    content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

            return JsonConvert.DeserializeObject<RootCampaignFolder>(content);
        }

        /// <summary>
        /// Get a specific campaign folder
        /// <param name="folder_id">Unique id for the campaign folder</param>
        /// </summary>
        internal async Task<CampaignFolder> GetSpecificCampaignFolderAsync(string folder_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaign_folders, SubTargetType.not_applicable, SubTargetType.not_applicable, folder_id);

            string content;
            using (var client = new HttpClient())
            {
                try
                {
                    Authenticate.ClientAuthentication(client);

                    content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

            return JsonConvert.DeserializeObject<CampaignFolder>(content);
        }

        /// <summary>
        /// Delete a campaign folder
        /// <param name="folder_id">Unique id for the campaign folder</param>
        /// </summary>
        internal async Task<HttpResponseMessage> DeleteSpecificCampaignFolderAsync(string folder_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.campaign_folders, SubTargetType.not_applicable, SubTargetType.not_applicable, folder_id);

            HttpResponseMessage result;
            using (var client = new HttpClient())
            {
                try
                {
                    Authenticate.ClientAuthentication(client);

                    result = await client.DeleteAsync(endpoint).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return result;
        }

    }
}
