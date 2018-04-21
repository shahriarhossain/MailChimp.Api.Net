using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.TemplateFolders;

namespace MailChimp.Api.Net.Services.TemplateFolders
{
  // =====================================================
  // AUTHOR      : Keith Fimreite, Enkode LLC
  // PURPOSE     : Organize your templates using folders
  // =====================================================

  public class MailChimpTemplateFolders
  {
    private MCTemplateFolderOverview mcTemplateFolderOverview;

    public MailChimpTemplateFolders()
    {
      mcTemplateFolderOverview = new MCTemplateFolderOverview();
    }
    
    /// <summary>
    /// Create a new template folder
    /// <param name="folderName">The name of the folder</param>
    /// </summary>
    public async Task<dynamic> AddTemplateFolderAsync(string folderName)
    {
      return await mcTemplateFolderOverview.AddTemplateFolderAsync(folderName);
    }

    /// <summary>
    /// Update a campaign folder
    /// <param name="name">Name to associate with the folder.</param>
    /// <param name="folder_id">Unique id for the list</param>
    /// </summary>
    public async Task<dynamic> UpdateTemplateFolderAsync(string name, string folder_id)
    {
      return await mcTemplateFolderOverview.UpdateTemplateFolderAsync(name, folder_id);
    }

    /// <summary>
    /// Get all template folders
    /// <param name="offset">The number of records from a collection to skip. Iterating over large collections with this parameter can be slow</param>
    /// <param name="count">The number of records to return.</param>    
    /// </summary>
    public async Task<RootTemplateFolder> GetAllTemplateFoldersAsync(int offset = 0, int count = 10)
    {
      return await mcTemplateFolderOverview.GetAllTemplateFoldersAsync(offset = 0, count = 10);
    }

    /// <summary>
    /// Get a specific template folder
    /// <param name="folder_id">Unique id for the template folder</param>
    /// </summary>
    public async Task<TemplateFolder> GetTemplateFolderAsync(string folder_id)
    {
      return await mcTemplateFolderOverview.GetTemplateFolderAsync(folder_id);
    }

    /// <summary>
    /// Delete a template folder
    /// <param name="folder_id">Unique id for the template folder</param>
    /// </summary>
    public async Task<HttpResponseMessage> DeleteTemplateFolderAsync(string folder_id)
    {
      return await mcTemplateFolderOverview.DeleteTemplateFolderAsync(folder_id);
    }

  }
}
