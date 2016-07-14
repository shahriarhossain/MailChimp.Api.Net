using System.Collections.Generic;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class RootUnsubscribe
    {
        public List<Unsubscribe> unsubscribes { get; set; }
        public string campaign_id { get; set; }
        public List<Link2> _links { get; set; }
        public int total_items { get; set; }
    }
}
