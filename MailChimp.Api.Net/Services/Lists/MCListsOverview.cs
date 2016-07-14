using System;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Lists;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Lists
{
    // ======================================================================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : A MailChimp list is a powerful and flexible tool that helps you manage your contacts. Learn how to get started with lists in MailChimp.
    // ======================================================================================================================================================

    internal class MCListsOverview
    {
        /// <summary>
        /// Get information about all lists
        /// </summary>
        internal async Task<RootMCLists> GetAllListsAsync(int offset = 0, int count = 10)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.not_applicable, SubTargetType.not_applicable);
            endpoint = String.Format("{0}?offset={1}&count={2}", endpoint, offset, count);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<RootMCLists>(content);
        }

        /// <summary>
        /// Get information about a specific list
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        internal async Task<MCLists> GetListAsync(string list_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.not_applicable, SubTargetType.not_applicable, list_id);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<MCLists>(content);
        }

        /// <summary>
        /// Delete a list
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        internal async Task<HttpResponseMessage> DeleteListAsync(string list_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.not_applicable, SubTargetType.not_applicable, list_id);

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
        /// Create a new list
        /// <param name="listName">The name of the list </param>
        /// <param name="contactForCampaignFotter">Contact information displayed in campaign footers to comply with international spam laws</param>
        /// <param name="permissionReminderText">The permission reminder for the list</param>
        /// <param name="defaultValue">Default values for campaigns created for this list</param>
        /// <param name="emailTypeOption">Whether the list supports multiple formats for emails.</param>
        /// <param name="listVisibility">Whether this list is public or private</param>
        /// </summary>
        internal async Task<dynamic> CreateListAsync(string listName, Contact contactForCampaignFotter, 
            string permissionReminderText, CampaignDefaults defaultValue, bool emailTypeOption=false,
            ListVisibility listVisibility = ListVisibility.pub)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.not_applicable, SubTargetType.not_applicable);

            MCLists mcListObject = new MCLists()
            {
                name= listName.ToString(),
                contact = contactForCampaignFotter,
                permission_reminder = permissionReminderText.ToString(),
                campaign_defaults =  defaultValue,
                email_type_option = emailTypeOption,
                visibility = listVisibility.ToString()
            };

            return await BaseOperation.PostAsync<MCLists>(endpoint, mcListObject);
        }

        /// <summary>
        /// Update a list
        /// <param name="list_id">Unique id for the list</param> 
        /// <param name="listName">The name of the list </param>
        /// <param name="contactForCampaignFotter">Contact information displayed in campaign footers to comply with international spam laws</param>
        /// <param name="permissionReminderText">The permission reminder for the list</param>
        /// <param name="defaultValue">Default values for campaigns created for this list</param>
        /// <param name="emailTypeOption">Whether the list supports multiple formats for emails.</param>
        /// <param name="listVisibility">Whether this list is public or private</param>
        /// </summary>
        internal async Task<dynamic> UpdateList(string list_id, string listName, Contact contactForCampaignFotter, 
            string permissionReminderText, CampaignDefaults defaultValue, bool emailTypeOption=false,
            ListVisibility listVisibility = ListVisibility.pub)
        {
            if (list_id == null)
              throw (new Exception("List ID must not be null"));

            MCLists list = new MCLists
            {
              name = listName,
              contact = contactForCampaignFotter,
              permission_reminder = permissionReminderText,
              campaign_defaults = defaultValue,
              email_type_option = emailTypeOption,
              visibility = listVisibility.ToString(),
              id = list_id
            };

          string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.not_applicable, SubTargetType.not_applicable, list_id, list_id);

          return await BaseOperation.PatchAsync<MCLists>(endpoint, list);
        }

    }
}
