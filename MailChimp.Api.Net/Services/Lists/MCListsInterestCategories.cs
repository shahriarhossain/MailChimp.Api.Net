using System;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Lists;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Lists
{
  // =======================================================================================================================================================================
  // AUTHOR      : Shahriar Hossain
  // PURPOSE     : Manage interest categories for a specific list. Interest categories organize interests, which are used to group subscribers based on their preferences.
  // =======================================================================================================================================================================

  internal class MCListsInterestCategories
  {
    #region interest categories
    /// <summary>
    /// Create a new interest category
    /// <param name="title">The text description of this category. This field appears on signup forms and is often phrased as a question</param>
    /// <param name="display_order">The order that the categories are displayed in the list. Lower numbers display first</param>
    /// <param name="type">Determines how this category’s interests are displayed on signup forms</param>
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    internal async Task<dynamic> CreateInterestCategoryAsync(string title, int display_order, InterestCategoryType type, string list_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.interest_categories, SubTargetType.not_applicable,
                                              list_id);
      InterestCategory interestCategory = new InterestCategory
        {
          display_order = display_order,
          type = type,
          title = title
        };

      return await BaseOperation.PostAsync<InterestCategory>(endpoint, interestCategory);
    }

    /// <summary>
    /// Update a specific interest category.
    /// <param name="title">The text description of this category. This field appears on signup forms and is often phrased as a question</param>
    /// <param name="display_order">The order that the categories are displayed in the list. Lower numbers display first</param>
    /// <param name="type">Determines how this category’s interests are displayed on signup forms</param>
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="interest_category_id">The unique id for the interest category.</param>
    /// </summary>
    internal async Task<dynamic> UpdateInterestCategoryAsync(string title, int display_order, InterestCategoryType type, string list_id, string interest_category_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.interest_categories, SubTargetType.not_applicable,
                                              list_id, interest_category_id);
      InterestCategory interestCategory = new InterestCategory
      {
        display_order = display_order,
        type = type,
        title = title
      };

      return await BaseOperation.PatchAsync<InterestCategory>(endpoint, interestCategory);
    }

    /// <summary>
    /// Get information about a list’s interest categories
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    internal async Task<RootListsInterestCategory> GetAllInterestCategoriesAsync(string list_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.interest_categories,
                                              SubTargetType.not_applicable, list_id);

      string content;
      using (var client = new HttpClient())
      {
        Authenticate.ClientAuthentication(client);

        content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
      }

      return JsonConvert.DeserializeObject<RootListsInterestCategory>(content);
    }

    /// <summary>
    /// Get information about a specific interest category
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="interest_category_id">Unique id for the interest category</param>
    /// </summary>
    internal async Task<InterestCategory> GetInterestCategoryAsync(string list_id, string interest_category_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.interest_categories,
                                              SubTargetType.not_applicable, list_id, interest_category_id);

      string content;
      using (var client = new HttpClient())
      {
        Authenticate.ClientAuthentication(client);

        content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
      }

      return JsonConvert.DeserializeObject<InterestCategory>(content);
    }

    /// <summary>
    /// Delete a specific interest category
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="interest_category_id">Unique id for the interest category</param>
    /// </summary>
    internal async Task<HttpResponseMessage> DeleteInterestCategoryAsync(string list_id, string interest_category_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.interest_categories,
                                              SubTargetType.not_applicable, list_id, interest_category_id);

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
    #endregion
    

    #region interest category interests
    /// <summary>
    /// Create a new interest or ‘group name’ for a specific category.
    /// <param name="name">The name of the interest. This can be shown publicly on a subscription form</param>
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="interest_category_id">	The unique id for the interest category</param>
    /// </summary>
    internal async Task<dynamic> CreateInterestCategoryInterestAsync(string name, string list_id, string interest_category_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.interest_categories, SubTargetType.interests,
                                              list_id, interest_category_id);

      Interest interest = new Interest
      {
        name = name
      };

      return await BaseOperation.PostAsync<Interest>(endpoint, interest);
    }

    /// <summary>
    /// Update interests or ‘group names’ for a specific category
    /// <param name="name">	The name of the interest. This can be shown publicly on a subscription form</param>
    /// <param name="display_order">The display order for interests.</param>
    /// <param name="list_id">The unique id for the list</param>
    /// <param name="subscriber_count">The number of subscribers associated with this interest.</param>
    /// <param name="interest_category_id">The unique id for the interest category</param>
    /// <param name="interest_id">	The specific interest or ‘group name’</param>
    /// </summary>
    internal async Task<dynamic> UpdateInterestCategoryInterestAsync(string name, int display_order, int subscriber_count, string list_id, string interest_category_id, string interest_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.interest_categories, SubTargetType.interests,
                                              list_id, interest_category_id);
      endpoint = String.Format("{0}/{1}", endpoint, interest_id);

      Interest interest = new Interest
      {
        list_id = list_id,
        subscriber_count = subscriber_count,
        name = name,
        display_order = display_order
      };

      return await BaseOperation.PatchAsync<Interest>(endpoint, interest);
    }
    
    /// <summary>
    /// Get all interests in a specific category
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="interest_category_id">Unique id for the interest category</param>
    /// </summary>
    internal async Task<RootInterest> GetAllInterestCategoryInterestsAsync(string list_id, string interest_category_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.interest_categories,
                                              SubTargetType.interests, list_id, interest_category_id);

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
    internal async Task<RootInterest> GetInterestCategoryInterestAsync(string list_id, string interest_category_id, string interest_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.interest_categories,
                                              SubTargetType.interests, list_id, interest_category_id);
      endpoint = String.Format("{0}/{1}", endpoint, interest_id);
      string content;
      using (var client = new HttpClient())
      {
        Authenticate.ClientAuthentication(client);

        content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
      }

      return JsonConvert.DeserializeObject<RootInterest>(content);
    }

    /// <summary>
    /// Delete interests in a specific category
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="interest_category_id">Unique id for the interest category</param>
    /// <param name="interest_id">The specific interest or ‘group name</param>
    /// </summary>
    internal async Task<HttpResponseMessage> DeleteInterestCategoryInterestAsync(string list_id,
                                                                              string interest_category_id,
                                                                              string interest_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.interest_categories,
                                              SubTargetType.interests, list_id, interest_category_id);
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
    #endregion
  }
}