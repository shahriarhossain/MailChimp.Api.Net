using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{

    //public class Bounces
    //{
    //    public int hard_bounces { get; set; }
    //    public int soft_bounces { get; set; }
    //    public int syntax_errors { get; set; }
    //}

    //public class Forwards
    //{
    //    public int forwards_count { get; set; }
    //    public int forwards_opens { get; set; }
    //}

    //public class Opens
    //{
    //    public int opens_total { get; set; }
    //    public int unique_opens { get; set; }
    //    public int open_rate { get; set; }
    //    public string last_open { get; set; }
    //}

    //public class Clicks
    //{
    //    public int clicks_total { get; set; }
    //    public int unique_clicks { get; set; }
    //    public int unique_subscriber_clicks { get; set; }
    //    public int click_rate { get; set; }
    //    public string last_click { get; set; }
    //}

    //public class FacebookLikes
    //{
    //    public int recipient_likes { get; set; }
    //    public int unique_likes { get; set; }
    //    public int facebook_likes { get; set; }
    //}

    //public class IndustryStats
    //{
    //    public string type { get; set; }
    //    public double open_rate { get; set; }
    //    public double click_rate { get; set; }
    //    public double bounce_rate { get; set; }
    //    public double unopen_rate { get; set; }
    //    public double unsub_rate { get; set; }
    //    public double abuse_rate { get; set; }
    //}

    //public class ListStats
    //{
    //    public int sub_rate { get; set; }
    //    public int unsub_rate { get; set; }
    //    public int open_rate { get; set; }
    //    public int click_rate { get; set; }
    //}

    //public class Timesery
    //{
    //    public string timestamp { get; set; }
    //    public int emails_sent { get; set; }
    //    public int unique_opens { get; set; }
    //    public int recipients_clicks { get; set; }
    //}

    //public class ShareReport
    //{
    //    public string share_url { get; set; }
    //    public string share_password { get; set; }
    //}

    //public class DeliveryStatus
    //{
    //    public bool enabled { get; set; }
    //}

    //public class Link
    //{
    //    public string rel { get; set; }
    //    public string href { get; set; }
    //    public string method { get; set; }
    //    public string targetSchema { get; set; }
    //    public string schema { get; set; }
    //}

    //public class Report
    //{
    //    public string id { get; set; }
    //    public string campaign_title { get; set; }
    //    public string type { get; set; }
    //    public int emails_sent { get; set; }
    //    public int abuse_reports { get; set; }
    //    public int unsubscribed { get; set; }
    //    public string send_time { get; set; }
    //    public Bounces bounces { get; set; }
    //    public Forwards forwards { get; set; }
    //    public Opens opens { get; set; }
    //    public Clicks clicks { get; set; }
    //    public FacebookLikes facebook_likes { get; set; }
    //    public IndustryStats industry_stats { get; set; }
    //    public ListStats list_stats { get; set; }
    //    public List<Timesery> timeseries { get; set; }
    //    public ShareReport share_report { get; set; }
    //    public DeliveryStatus delivery_status { get; set; }
    //    public List<Link> _links { get; set; }
    //}

    //public class Link2
    //{
    //    public string rel { get; set; }
    //    public string href { get; set; }
    //    public string method { get; set; }
    //    public string targetSchema { get; set; }
    //    public string schema { get; set; }
    //}

    public class RootSub_Reports
    {
        public List<Report> reports { get; set; }
        public string campaign_id { get; set; }
        public List<Link2> _links { get; set; }
        public int total_items { get; set; }
    }
}
