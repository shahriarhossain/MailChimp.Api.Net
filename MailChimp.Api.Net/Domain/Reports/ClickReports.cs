using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{
    //public class Link
    //{
    //    public string rel { get; set; }
    //    public string href { get; set; }
    //    public string method { get; set; }
    //    public string targetSchema { get; set; }
    //}

    public class UrlsClicked
    {
        public string id { get; set; }
        public string url { get; set; }
        public int total_clicks { get; set; }
        public int click_percentage { get; set; }
        public int unique_clicks { get; set; }
        public int unique_click_percentage { get; set; }
        public string last_click { get; set; }
        public string campaign_id { get; set; }
        public List<Link> _links { get; set; }
    }

    //public class Link2
    //{
    //    public string rel { get; set; }
    //    public string href { get; set; }
    //    public string method { get; set; }
    //    public string targetSchema { get; set; }
    //}

    public class ClickReports
    {
        public List<UrlsClicked> urls_clicked { get; set; }
        public string campaign_id { get; set; }
        public List<Link2> _links { get; set; }
        public int total_items { get; set; }
    }
}
