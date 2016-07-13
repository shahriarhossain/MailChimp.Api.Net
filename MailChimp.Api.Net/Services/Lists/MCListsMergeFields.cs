using System;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Lists;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Lists
{
    // ===============================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Manage merge fields (formerly merge vars) for a specific list.
    // ===============================================================================

    
    internal class MCListsMergeFields
    {
        /// <summary>
        /// Add a new list merge field
        /// <param name="mergeField">The merge field to add.</param>
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        internal async Task<dynamic> AddMergeField(MergeField mergeField, string list_id)
        {
          string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.merge_fields, SubTargetType.not_applicable, list_id);

          return await BaseOperation.PostAsync<MergeField>(endpoint, mergeField);
        }
      
        /// <summary>
        /// Update a list merge field
        /// <param name="mergeField">Merge field to update</param>
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        internal async Task<dynamic> UpdateMergeField(MergeField mergeField, string list_id)
        {
          if (mergeField.merge_id < 0)
            throw (new Exception("Merge Field ID must not be less than zero."));

          string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.merge_fields, SubTargetType.not_applicable, list_id, Convert.ToString(mergeField.merge_id));

          return await BaseOperation.PatchAsync<MergeField>(endpoint, mergeField);
        }

        /// <summary>
        /// Get all merge fields for a list
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        internal async Task<RootMergeField> GetAllMergeFieldsAsync(string list_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.merge_fields, SubTargetType.not_applicable, list_id);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<RootMergeField>(content);
        }


        /// <summary>
        /// Get a specific merge field
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="merge_id">The id for the merge field</param>
        /// </summary>
        internal async Task<MergeField> GetMergeFieldAsync(string list_id, string merge_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.merge_fields, SubTargetType.not_applicable, list_id, merge_id);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<MergeField>(content);
        }


        /// <summary>
        /// Delete a merge field
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="merge_id">The id for the merge field</param>
        /// </summary>
        internal async Task<HttpResponseMessage> DeleteMergeFieldAsync(string list_id, string merge_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.merge_fields, SubTargetType.not_applicable, list_id, merge_id);

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
