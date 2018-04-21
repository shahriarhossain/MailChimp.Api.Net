using System;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Templates;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Templates
{
  // ====================================================================================================================================
  // AUTHOR      : Keith Fimreite, Enkode LLC
  // PURPOSE     : Manage your MailChimp templates. A template is an HTML file used to create the layout and basic design for a campaign.
  // ====================================================================================================================================

  internal class MCTemplatesOverview
  {
    /// <summary>
    /// Create a new template
    /// <param name="templateName">The name of the template</param>
    /// <param name="html">The raw HTML for the template. We support the MailChimp Template Language in any HTML code passed via the API</param>
    /// <param name="folder_id" optional>The id of the folder the template is currently in</param> 
    /// </summary>
    internal async Task<dynamic> CreateTemplateAsync(string templateName, string html, string folder_id = null)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.templates, SubTargetType.not_applicable,
                                              SubTargetType.not_applicable);

      Template templateObject = new Template()
        {
          name = templateName,
          folder_id = folder_id,
          html = html
        };

      return await BaseOperation.PostAsync<Template>(endpoint, templateObject);
    }

    /// <summary>
    /// Get all templates
    /// <param name="offset">The number of records from a collection to skip. Iterating over large collections with this parameter can be slow</param>
    /// <param name="count">The number of records to return.</param>
    /// </summary>
    internal async Task<RootTemplate> GetAllTemplatesAsync(int offset = 0, int count = 10)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.templates, SubTargetType.not_applicable,
                                              SubTargetType.not_applicable);
      endpoint = String.Format("{0}?offset={1}&count={2}", endpoint, offset, count);

      return await BaseOperation.GetAsync<RootTemplate>(endpoint);
    }

    /// <summary>
    /// Get information about a specific template
    /// <param name="template_id">The unique id for the template.</param>
    /// </summary>
    internal async Task<Template> GetTemplateAsync(string template_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.templates, SubTargetType.not_applicable,
                                              SubTargetType.not_applicable, template_id);

      return await BaseOperation.GetAsync<Template>(endpoint);
    }

    /// <summary>
    /// Delete a specific template
    /// <param name="template_id">The unique id for the template</param>
    /// </summary>
    internal async Task<HttpResponseMessage> DeleteTemplateAsync(string template_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.templates, SubTargetType.not_applicable,
                                              SubTargetType.not_applicable, template_id);

      return await BaseOperation.DeleteAsync(endpoint);
    }

    /// <summary>
    /// Update specific template
    /// <param name="name">The new name of the template</param>
    /// <param name="html">The new HTML of the template</param>
    /// <param name="folder_id">The folder Id of the template</param>
    /// <param name="templateId">The template identifier</param>        
    /// </summary>        
    internal async Task<dynamic> UpdateTemplateAsync(string name, string html, string templateId, string folder_id = null)
    {
      if (templateId == null)
        throw (new Exception("Template ID must not be null"));

      string endpoint = Authenticate.EndPoint(TargetTypes.templates, SubTargetType.not_applicable,
                                              SubTargetType.not_applicable, templateId);

      Template templateObject = new Template()
        {
          name = name,
          folder_id = folder_id,
          html = html
        };

      return await BaseOperation.PatchAsync<Template>(endpoint, templateObject);
    }
  }
}