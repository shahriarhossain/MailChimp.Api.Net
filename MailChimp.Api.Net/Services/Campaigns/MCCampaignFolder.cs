using System;
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
    /// Add a new campaign folder
    /// <param name="name">Name to associate with the folder.</param>
    /// </summary>
    internal async Task<dynamic> AddCampaignFolderAsync(string name)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.campaign_folders, SubTargetType.not_applicable, SubTargetType.not_applicable);

      CampaignFolder campaignFolderObject = new CampaignFolder
      {
        name = name
      };

      return await BaseOperation.PostAsync<CampaignFolder>(endpoint, campaignFolderObject);
    }


    /// <summary>
    /// Update a campaign folder
    /// <param name="name">Name to associate with the folder.</param>
    /// <param name="folder_id">Unique id for the list</param>
    /// </summary>
    internal async Task<dynamic> UpdateCampaignFolderAsync(string name, string folder_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.campaign_folders, SubTargetType.not_applicable, SubTargetType.not_applicable, folder_id);

      CampaignFolder campaignFolderObject = new CampaignFolder
      {
        name = name,
        id = folder_id
      };

      return await BaseOperation.PatchAsync<CampaignFolder>(endpoint, campaignFolderObject);
    }

    /// <summary>
    /// Get all campaign folders
    /// <param name="offset">The number of records from a collection to skip. Iterating over large collections with this parameter can be slow</param>
    /// <param name="count">The number of records to return.</param>
    /// </summary>
    internal async Task<RootCampaignFolder> GetAllCampaignFoldersAsync(int offset = 0, int count = 10)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.campaign_folders, SubTargetType.not_applicable,
                                              SubTargetType.not_applicable);
      endpoint = String.Format("{0}?offset={1}&count={2}", endpoint, offset, count);

      return await BaseOperation.GetAsync<RootCampaignFolder>(endpoint);
    }

    /// <summary>
    /// Get a specific campaign folder
    /// <param name="folder_id">Unique id for the campaign folder</param>
    /// </summary>
    internal async Task<CampaignFolder> GetCampaignFolderAsync(string folder_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.campaign_folders, SubTargetType.not_applicable,
                                              SubTargetType.not_applicable, folder_id);

      return await BaseOperation.GetAsync<CampaignFolder>(endpoint);
    }

    /// <summary>
    /// Delete a campaign folder
    /// <param name="folder_id">Unique id for the campaign folder</param>
    /// </summary>
    internal async Task<HttpResponseMessage> DeleteCampaignFolderAsync(string folder_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.campaign_folders, SubTargetType.not_applicable,
                                              SubTargetType.not_applicable, folder_id);

      return await BaseOperation.DeleteAsync(endpoint);
    }
  }
}