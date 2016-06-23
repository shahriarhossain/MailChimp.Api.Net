using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.TemplateFolders;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.TemplateFolders
{
    // =====================================================
    // AUTHOR      : Keith Fimreite
    // PURPOSE     : Organize your templates using folders
    // =====================================================

    public class MailChimpTemplateFolders
    {
        /// <summary>
        /// Create a new template folder
        /// <param name="folderName">The name of the folder</param>
        /// </summary>
        public async Task<dynamic> CreateTemplateFolderAsync(string folderName)
        {
          string endpoint = Authenticate.EndPoint(TargetTypes.template_folders, SubTargetType.not_applicable, SubTargetType.not_applicable);

          TemplateFolder templateFolderObject = new TemplateFolder()
          {
            name = folderName
          };

          return await BaseOperation.PostAsync<TemplateFolder>(endpoint, templateFolderObject);
        }

        /// <summary>
        /// Get all template folders
        /// </summary>
        public async Task<RootTemplateFolder> GetAllTemplateFoldersAsync()
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.template_folders, SubTargetType.not_applicable, SubTargetType.not_applicable);

            return await BaseOperation.GetAsync<RootTemplateFolder>(endpoint);
        }

        /// <summary>
        /// Get a specific template folder
        /// <param name="folder_id">Unique id for the template folder</param>
        /// </summary>
        public async Task<TemplateFolder> GetTemplateFolderAsync(string folder_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.template_folders, SubTargetType.not_applicable, SubTargetType.not_applicable, folder_id);

            return await BaseOperation.GetAsync<TemplateFolder>(endpoint);
        }

        /// <summary>
        /// Delete a template folder
        /// <param name="folder_id">Unique id for the template folder</param>
        /// </summary>
        public async Task<HttpResponseMessage> DeleteTemplateFolderAsync(string folder_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.template_folders, SubTargetType.not_applicable, SubTargetType.not_applicable, folder_id);

            return await BaseOperation.DeleteAsync(endpoint);
        }

    }
}
