using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Campaigns
{
    public class Campaign 
    {
        public string id { get; set; }
        public string type { get; set; }
        public string create_time { get; set; }
        public string archive_url { get; set; }
        public string status { get; set; }
        public int? emails_sent { get; set; }
        public string send_time { get; set; }
        public string content_type { get; set; }
        public Recipients recipients { get; set; }
        public Settings settings { get; set; }
        public Tracking tracking { get; set; }
        public DeliveryStatus delivery_status { get; set; }
        public List<Link> _links { get; set; }
        public ReportSummary report_summary { get; set; }
        public VariateSettings variate_settings { get; set; }
      
    }
}
