using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Lists;
using MailChimp.Api.Net.Enum;
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
        internal async Task<MergeField> GetAllMergeFieldsAsync(string list_id, string merge_id)
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
    }
}
