using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Feedback
{
    public class Feedback
    {
        public int feedback_id { get; set; }
        public int parent_id { get; set; }
        public int block_id { get; set; }
        public string message { get; set; }
        public bool is_complete { get; set; }
        public string created_by { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string source { get; set; }
        public string campaign_id { get; set; }
        public List<Link> _links { get; set; }
    }
}
