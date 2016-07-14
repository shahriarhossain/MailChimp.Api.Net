using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Conversations
{
    public class Conversation
    {
        public string id { get; set; }
        public int message_count { get; set; }
        public string campaign_id { get; set; }
        public string list_id { get; set; }
        public int unread_messages { get; set; }
        public string from_label { get; set; }
        public string from_email { get; set; }
        public string subject { get; set; }
        public LastMessage last_message { get; set; }
        public List<Link> _links { get; set; }
    }
}
