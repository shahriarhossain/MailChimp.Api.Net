using System.Collections.Generic;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class Report
    {
        public string id { get; set; }
        public string campaign_title { get; set; }
        public string type { get; set; }
        public int emails_sent { get; set; }
        public int abuse_reports { get; set; }
        public int unsubscribed { get; set; }
        public string send_time { get; set; }
        public Bounces bounces { get; set; }
        public Forwards forwards { get; set; }
        public Opens opens { get; set; }
        public Clicks clicks { get; set; }
        public FacebookLikes facebook_likes { get; set; }
        public IndustryStats industry_stats { get; set; }
        public ListStats list_stats { get; set; }
        public List<Timesery> timeseries { get; set; }
        public ShareReport share_report { get; set; }
        public DeliveryStatus delivery_status { get; set; }
        public List<Link> _links { get; set; }
    }
}
