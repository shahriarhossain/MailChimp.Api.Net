using System;
using System.Net.Http;
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

        /// <summary>
        /// Get all interests in a specific category
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="interest_category_id">Unique id for the interest category</param>
        /// </summary>
        internal async Task<RootInterest> GetAllInterestsForSpecifiedCategoryAsync(string list_id, string interest_category_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.interest_categories, SubTargetType.interests, list_id, interest_category_id);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<RootInterest>(content);
        }

        /// <summary>
        /// Get interests in a specific category
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="interest_category_id">Unique id for the interest category</param>
        /// <param name="interest_id">The specific interest or ‘group name</param>
        /// </summary>
        internal async Task<Interest> GetInterestsForSpecifiedCategoryAsync(string list_id, string interest_category_id, string interest_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.interest_categories, SubTargetType.interests, list_id, interest_category_id);
            endpoint = String.Format("{0}/{1}", endpoint, interest_id);
            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<Interest>(content);
        }

        /// <summary>
        /// Delete a specific interest category
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="interest_category_id">Unique id for the interest category</param>
        /// </summary>
        internal async Task<HttpResponseMessage> DeleteSpecificInterestCategoryAsync(string list_id, string interest_category_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.interest_categories, SubTargetType.not_applicable, list_id, interest_category_id);

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

        /// <summary>
        /// Delete interests in a specific category
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="interest_category_id">Unique id for the interest category</param>
        /// <param name="interest_id">The specific interest or ‘group name</param>
        /// </summary>
        internal async Task<HttpResponseMessage> DeleteInterestInSpecificCategoryAsync(string list_id, string interest_category_id, string interest_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.interest_categories, SubTargetType.interests, list_id, interest_category_id);
            endpoint = String.Format("{0}/{1}", endpoint, interest_id);

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
