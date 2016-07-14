using System;
using System.Net.Http;
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

    internal class MCListsMembers
    {

        /// <summary>
        /// Add a new list member
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        internal async Task<dynamic> AddMember(MCMember member, string list_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.members, SubTargetType.not_applicable, list_id);

            return await BaseOperation.PostAsync<MCMember>(endpoint, member);
        }


        /// <summary>
        /// Update a list member
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        internal async Task<dynamic> UpdateMember(MCMember member, string list_id)
        {
            if (member.id == null)
                throw (new Exception("Member ID must not be null"));

            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.members, SubTargetType.not_applicable, list_id, member.id);

            return await BaseOperation.PutAsync<MCMember>(endpoint, member);
        }

        /// <summary>
        /// Get information about members in a list
        /// <param name="list_id">Unique id for the list</param>
        /// </summary>
        internal async Task<RootMember> GetMemberInfoOfAListAsync(string list_id, int offset = 0, int count = 10)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.members, SubTargetType.not_applicable, list_id);
            endpoint = String.Format("{0}?offset={1}&count={2}", endpoint, offset, count);

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
        /// Delete a list member
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
        /// </summary>
        internal async Task<HttpResponseMessage> DeleteMemberAsync(string list_id, string subscriber_hash)
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
