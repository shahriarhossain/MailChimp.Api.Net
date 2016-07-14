using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Conversations
{
    public class RootConversation
    {
        public List<Conversation> conversations { get; set; }
        public int total_items { get; set; }
        public List<Link2> _links { get; set; }
    }
}
