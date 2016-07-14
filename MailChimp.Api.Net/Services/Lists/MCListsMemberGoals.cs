using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Lists;
using MailChimp.Api.Net.Enum;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Lists
{
    // ====================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Get information about recent goal events for a specific list member.
    // ====================================================================================

    internal class MCListsMemberGoals
    {
        /// <summary>
        /// Get the last 50 Goal events for a member on a specific list
        /// <param name="list_id">Unique id for the list</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
        /// </summary>
        internal async Task<RootGoal> GetLast50GoalAsync(string list_id, string subscriber_hash)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.members, SubTargetType.goals, list_id, subscriber_hash);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<RootGoal>(content);
        }

    }
}
