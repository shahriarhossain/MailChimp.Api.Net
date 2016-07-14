using System.Collections.Generic;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class CampaignAdvice
    {
        public List<Advice> advice { get; set; }
        public string campaign_id { get; set; }
        public List<Link> _links { get; set; }
        public int total_items { get; set; }
    }
}
