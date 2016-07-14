using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Feedback
{
    public class RootFeedback
    {
        public List<Feedback> feedback { get; set; }
        public string campaign_id { get; set; }
        public int total_items { get; set; }
        public List<Link2> _links { get; set; }
    }
}
