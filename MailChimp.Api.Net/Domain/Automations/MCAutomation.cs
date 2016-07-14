using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Campaigns;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Automations
{ 
    public class MCAutomation
    {
        public string id { get; set; }
        public string create_time { get; set; }
        public string start_time { get; set; }
        public string status { get; set; }
        public int emails_sent { get; set; }
        public Recipients recipients { get; set; }
        public Settings settings { get; set; }
        public Tracking tracking { get; set; }
        public TriggerSettings trigger_settings { get; set; }
        public ReportSummary report_summary { get; set; }
        public List<Link> _links { get; set; }
    }
}
