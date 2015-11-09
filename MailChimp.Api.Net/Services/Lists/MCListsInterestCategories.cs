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
    // =======================================================================================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Manage interest categories for a specific list. Interest categories organize interests, which are used to group subscribers based on their preferences.
    // =======================================================================================================================================================================

    internal class MCListsInterestCategories
    {
        /// <summary>
        /// Get information about a list’s interest categories
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        internal async Task<RootListsCategory> GetInterestCategoriesAsync(string list_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.interest_categories, SubTargetType.not_applicable, list_id);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<RootListsCategory>(content);
        }

        /// <summary>
        /// Get information about a specific interest category
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="interest_category_id">Unique id for the interest category</param>
        /// </summary>
        internal async Task<Category> GetInfoForSpecificListCategoryAsync(string list_id, string interest_category_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.interest_categories, SubTargetType.not_applicable, list_id, interest_category_id);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<Category>(content);
        }
    }
}
