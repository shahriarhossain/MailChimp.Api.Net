using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Conversations;

namespace MailChimp.Api.Net.Services.Conversations
{
  // ============================================================================================================================================
  // AUTHOR      : Shahriar Hossain
  // PURPOSE     : Conversation tracking is a paid feature that lets you view subscribers’ replies to your campaigns in your MailChimp account.
  ///              Manage messages in a specific campaign conversation.
  // ============================================================================================================================================
  public class MailChimpConversation
  {
    private MCConversationOverview overview;
    private MCConversationsMessages msg;

    public MailChimpConversation()
    {
      overview = new MCConversationOverview();
      msg = new MCConversationsMessages();
    }

    #region overview

    /// <summary>
    /// Get a list of conversations
    /// </summary>
    public async Task<RootConversation> GetConversationsAsync()
    {
      return await overview.GetConversationsAsync();
    }

    /// <summary>
    /// Get information about a conversation
    /// <param name="conversation_id">Unique id for the campaign</param>
    /// </summary>
    public async Task<Conversation> GetConversationAsync(string conversation_id)
    {
      return await overview.GetConversationAsync(conversation_id);
    }

    #endregion overview

    #region msg

    /// <summary>
    /// Get conversation messages
    /// <param name="conversation_id">Unique id for the campaign</param>
    /// </summary>
    public async Task<RootConversationMessage> GetAllMessagesAsync(string conversation_id)
    {
      return await msg.GetAllMessagesAsync(conversation_id);
    }

    /// <summary>
    /// Get conversation messages
    /// <param name="conversation_id">Unique id for the campaign</param>
    /// <param name="message_id">The unique id for the conversation message</param>
    /// </summary>
    public async Task<ConversationMessage> GetMessageAsync(string conversation_id, string message_id)
    {
      return await msg.GetMessageAsync(conversation_id, message_id);
    }

    #endregion msg
  }
}