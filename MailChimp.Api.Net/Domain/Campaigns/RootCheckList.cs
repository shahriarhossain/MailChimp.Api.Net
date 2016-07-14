using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Campaigns
{
    public class RootCheckList
    {
        public bool is_ready { get; set; }
        public List<Item> items { get; set; }
        public List<Link> _links { get; set; }
    }
}
