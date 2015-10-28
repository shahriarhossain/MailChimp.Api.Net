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

    public class SentTo
    {
        public string email_id { get; set; }
        public string email_address { get; set; }
        public string status { get; set; }
        public int open_count { get; set; }
        public string last_open { get; set; }
        public string absplit_group { get; set; }
        public int gmt_offset { get; set; }
        public string campaign_id { get; set; }
        public string list_id { get; set; }
        public List<Link> _links { get; set; }
    }

    //public class Link2
    //{
    //    public string rel { get; set; }
    //    public string href { get; set; }
    //    public string method { get; set; }
    //    public string targetSchema { get; set; }
    //}

    public class RootSentTo
    {
        public List<SentTo> sent_to { get; set; }
        public string campaign_id { get; set; }
        public List<Link2> _links { get; set; }
        public int total_items { get; set; }
    }
}
