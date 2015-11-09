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
    // ======================================================================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : A MailChimp list is a powerful and flexible tool that helps you manage your contacts. Learn how to get started with lists in MailChimp.
    // ======================================================================================================================================================

    internal class MCListsOverview
    {
        /// <summary>
        /// Get information about all lists
        /// </summary>
        internal async Task<RootMCLists> GetAllListsAsync()
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.not_applicable, SubTargetType.not_applicable);

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
        internal async Task<MCLists> GetAllListsAsync(string list_id)
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


    }
}
