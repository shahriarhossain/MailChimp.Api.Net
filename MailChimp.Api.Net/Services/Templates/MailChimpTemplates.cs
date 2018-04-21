using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Templates;

namespace MailChimp.Api.Net.Services.Templates
{
  // ====================================================================================================================================
  // AUTHOR      : Shahriar Hossain
  // PURPOSE     : Manage your MailChimp templates. A template is an HTML file used to create the layout and basic design for a campaign.
  // ====================================================================================================================================

  public class MailChimpTemplates
  {
    private MCTemplatesOverview mcTemplatesOverview;

    public MailChimpTemplates()
    {
      mcTemplatesOverview = new MCTemplatesOverview();  
    }


    /// <summary>
    /// Create a new template
    /// <param name="templateName">The name of the template</param>
    /// <param name="html">The raw HTML for the template. We support the MailChimp Template Language in any HTML code passed via the API</param>
    /// <param name="folder_id" optional>The id of the folder the template is currently in</param> 
    /// </summary>
    public async Task<dynamic> CreateTemplateAsync(string templateName, string html, string folder_id = null)
    {
      return await mcTemplatesOverview.CreateTemplateAsync(templateName, html, folder_id = null);
    }

    /// <summary>
    /// Get all templates
    /// <param name="offset">The number of records from a collection to skip. Iterating over large collections with this parameter can be slow</param>
    /// <param name="count">The number of records to return.</param>
    /// </summary>
    public async Task<RootTemplate> GetAllTemplatesAsync(int offset = 0, int count = 10)
    {
      return await mcTemplatesOverview.GetAllTemplatesAsync(offset = 0, count = 10);
    }

    /// <summary>
    /// Get information about a specific template
    /// <param name="template_id">The unique id for the template.</param>
    /// </summary>
    public async Task<Template> GetTemplateAsync(string template_id)
    {
      return await mcTemplatesOverview.GetTemplateAsync(template_id);
    }

    /// <summary>
    /// Delete a specific template
    /// <param name="template_id">The unique id for the template</param>
    /// </summary>
    public async Task<HttpResponseMessage> DeleteTemplateAsync(string template_id)
    {
      return await mcTemplatesOverview.DeleteTemplateAsync(template_id);
    }

    /// <summary>
    /// Update specific template
    /// <param name="name">The new name of the template</param>
    /// <param name="html">The new HTML of the template</param>
    /// <param name="folder_id">The folder Id of the template</param>
    /// <param name="templateId">The template identifier</param>        
    /// </summary>        
    public async Task<dynamic> UpdateTemplateAsync(string name, string html, string templateId, string folder_id = null)
    {
      return await mcTemplatesOverview.UpdateTemplateAsync(name, html, templateId, folder_id);
    }
  }
}