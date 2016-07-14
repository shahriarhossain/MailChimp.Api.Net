using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Conversations;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Conversations
{
    // ============================================================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Conversation tracking is a paid feature that lets you view subscribers’ replies to your campaigns in your MailChimp account.
    // ============================================================================================================================================

    internal class MCConversationOverview
    {
        /// <summary>
        /// Get a list of conversations
        /// </summary>
        internal async Task<RootConversation> GetConversationsAsync()
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.conversations, SubTargetType.not_applicable, SubTargetType.not_applicable);

            return await BaseOperation.GetAsync<RootConversation>(endpoint);
        }


        /// <summary>
        /// Get information about a conversation
        /// <param name="conversation_id">Unique id for the campaign</param>
        /// </summary>
        internal async Task<Conversation> GetConversationByIdAsync(string conversation_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.conversations, SubTargetType.not_applicable, SubTargetType.not_applicable, conversation_id);

            return await BaseOperation.GetAsync<Conversation>(endpoint);
        }
    }
}
