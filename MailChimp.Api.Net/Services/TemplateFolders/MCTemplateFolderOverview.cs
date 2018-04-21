using System;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.TemplateFolders;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.TemplateFolders
{
  // =====================================================
  // AUTHOR      : Keith Fimreite, Enkode LLC
  // PURPOSE     : Organize your templates using folders
  // =====================================================

  internal class MCTemplateFolderOverview
  {
    /// <summary>
    /// Create a new template folder
    /// <param name="folderName">The name of the folder</param>
    /// </summary>
    internal async Task<dynamic> AddTemplateFolderAsync(string folderName)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.template_folders, SubTargetType.not_applicable, SubTargetType.not_applicable);

      TemplateFolder templateFolderObject = new TemplateFolder
        {
        name = folderName
      };

      return await BaseOperation.PostAsync<TemplateFolder>(endpoint, templateFolderObject);
    }

    /// <summary>
    /// Update a campaign folder
    /// <param name="name">Name to associate with the folder.</param>
    /// <param name="folder_id">Unique id for the list</param>
    /// </summary>
    internal async Task<dynamic> UpdateTemplateFolderAsync(string name, string folder_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.template_folders, SubTargetType.not_applicable, SubTargetType.not_applicable, folder_id);

      TemplateFolder templateFolderObject = new TemplateFolder
      {
        name = name,
        id = folder_id
      };
      return await BaseOperation.PatchAsync<TemplateFolder>(endpoint, templateFolderObject);
    }

    /// <summary>
    /// Get all template folders
    /// <param name="offset">The number of records from a collection to skip. Iterating over large collections with this parameter can be slow</param>
    /// <param name="count">The number of records to return.</param>    
    /// </summary>
    internal async Task<RootTemplateFolder> GetAllTemplateFoldersAsync(int offset = 0, int count = 10)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.template_folders, SubTargetType.not_applicable, SubTargetType.not_applicable);
      endpoint = String.Format("{0}?offset={1}&count={2}", endpoint, offset, count);

      return await BaseOperation.GetAsync<RootTemplateFolder>(endpoint);
    }

    /// <summary>
    /// Get a specific template folder
    /// <param name="folder_id">Unique id for the template folder</param>
    /// </summary>
    internal async Task<TemplateFolder> GetTemplateFolderAsync(string folder_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.template_folders, SubTargetType.not_applicable, SubTargetType.not_applicable, folder_id);

      return await BaseOperation.GetAsync<TemplateFolder>(endpoint);
    }

    /// <summary>
    /// Delete a template folder
    /// <param name="folder_id">Unique id for the template folder</param>
    /// </summary>
    internal async Task<HttpResponseMessage> DeleteTemplateFolderAsync(string folder_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.template_folders, SubTargetType.not_applicable, SubTargetType.not_applicable, folder_id);

      return await BaseOperation.DeleteAsync(endpoint);
    }

  }
}
