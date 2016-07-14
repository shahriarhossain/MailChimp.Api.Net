using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class RootMember
    {
        public List<MCMember> members { get; set; }
        public string list_id { get; set; }
        public List<Link2> _links { get; set; }
        public int total_items { get; set; }
    }
}
