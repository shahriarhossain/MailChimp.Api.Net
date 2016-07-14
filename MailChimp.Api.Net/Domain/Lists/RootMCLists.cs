using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class RootMCLists
    {
        public List<MCLists> lists { get; set; }
        public List<Link2> _links { get; set; }
        public int total_items { get; set; }
    }
}
