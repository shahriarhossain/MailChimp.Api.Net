using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Campaigns;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Automations
{
    public class AutomationsEmail
    {
        public string id { get; set; }
        public string workflow_id { get; set; }
        public int position { get; set; }
        public Delay delay { get; set; }
        public string create_time { get; set; }
        public string start_time { get; set; }
        public string archive_url { get; set; }
        public string status { get; set; }
        public int emails_sent { get; set; }
        public string send_time { get; set; }
        public string content_type { get; set; }
        public Recipients recipients { get; set; }
        public Settings settings { get; set; }
        public Tracking tracking { get; set; }
        public ReportSummary report_summary { get; set; }
        public List<Link> _links { get; set; }
    }
}
