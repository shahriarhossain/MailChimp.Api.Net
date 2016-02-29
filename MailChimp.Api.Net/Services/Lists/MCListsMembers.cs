using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Lists;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Lists
{
    // ==================================================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Manage members of a specific MailChimp list, including currently subscribed, unsubscribed, and bounced members.
    // ==================================================================================================================================

    internal  class MCListsMembers
    {

        /// <summary>
        /// Add a new list member
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        internal async Task<dynamic> AddMember(MCMember member, string listId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.members, SubTargetType.not_applicable, listId);

            return await BaseOperation.PostAsync<MCMember>(endpoint, member);
        }
        
  
        /// <summary>
        /// Get information about members in a list
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        internal async Task<RootMember> GetMemberInfoOfAListAsync(string list_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.members, SubTargetType.not_applicable, list_id);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<RootMember>(content);
        }


        /// <summary>
        /// Get information about a specific list member
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
        /// </summary>
        internal async Task<MCMember> GetMemberInfoAsync(string list_id, string subscriber_hash)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.members, SubTargetType.not_applicable, list_id, subscriber_hash);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<MCMember>(content);
        }


        /// <summary>
        /// Remove a list member
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
        /// </summary>
        internal async Task<HttpResponseMessage> DeleteListMemberAsync(string list_id, string subscriber_hash)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.members, SubTargetType.not_applicable, list_id, subscriber_hash);

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
