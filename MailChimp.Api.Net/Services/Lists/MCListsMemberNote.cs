using System;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Lists;
using MailChimp.Api.Net.Enum;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Lists
{
    // ================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Retrieve recent notes for a specific list member.
    // ================================================================

    internal class MCListsMemberNote
    {
        /// <summary>
        /// Get recent notes for a specific list member
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
        /// </summary>
        internal async Task<RootNote> GetLast50GoalAsync(string list_id, string subscriber_hash)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.members, SubTargetType.notes, list_id, subscriber_hash);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<RootNote>(content);
        }


        /// <summary>
        /// Get a specific note for a specific list member
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
        /// <param name="note_id">The id for the note.</param>
        /// </summary>
        internal async Task<Note> GetSpecificNoteAsync(string list_id, string subscriber_hash, string note_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.members, SubTargetType.notes, list_id, subscriber_hash);

            endpoint = String.Format("{0}/{1}", endpoint, note_id);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<Note>(content);
        }

        /// <summary>
        /// Delete a note
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
        /// <param name="note_id">The id for the note.</param>
        /// </summary>
        internal async Task<HttpResponseMessage> DeleteListMemberAsync(string list_id, string subscriber_hash, string note_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.members, SubTargetType.notes, list_id, subscriber_hash);
            endpoint = String.Format("{0}/{1}", endpoint, note_id);
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
