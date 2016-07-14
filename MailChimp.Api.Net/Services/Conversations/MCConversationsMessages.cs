using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Conversations;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Conversations
{
    // ==================================================================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Manage messages in a specific campaign conversation.
    // ===================================================================================================================================================
    internal class MCConversationsMessages
    {
        /// <summary>
        /// Get conversation messages
        /// <param name="conversation_id">Unique id for the campaign</param>
        /// </summary>
        internal async Task<RootConversationMessage> GetALLMessagesAsync(string conversation_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.conversations, SubTargetType.messages, SubTargetType.not_applicable, conversation_id);

            return await BaseOperation.GetAsync<RootConversationMessage>(endpoint);
        }


        /// <summary>
        /// Get conversation messages
        /// <param name="conversation_id">Unique id for the campaign</param>
        /// <param name="message_id">The unique id for the conversation message</param>
        /// </summary>
        internal async Task<ConversationMessage> GetMessageByIdAsync(string conversation_id, string message_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.conversations, SubTargetType.messages, SubTargetType.not_applicable, conversation_id, message_id);

            return await BaseOperation.GetAsync<ConversationMessage>(endpoint);
        }


    }
}
