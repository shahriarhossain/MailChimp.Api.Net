using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Conversations
{
    public class ConversationMessage
    {
        public string id { get; set; }
        public string conversation_id { get; set; }
        public int list_id { get; set; }
        public string from_label { get; set; }
        public string from_email { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public bool read { get; set; }
        public string timestamp { get; set; }
        public List<Link> _links { get; set; }
    }
}
