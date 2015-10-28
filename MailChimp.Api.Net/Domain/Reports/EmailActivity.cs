using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class Activity
    {
        public string action { get; set; }
        public string timestamp { get; set; }
        public string ip { get; set; }
    }

    //public class Link
    //{
    //    public string rel { get; set; }
    //    public string href { get; set; }
    //    public string method { get; set; }
    //    public string targetSchema { get; set; }
    //}

    public class Email
    {
        public string campaign_id { get; set; }
        public string list_id { get; set; }
        public string email_id { get; set; }
        public string email_address { get; set; }
        public List<Activity> activity { get; set; }
        public List<Link> _links { get; set; }
    }

    //public class Link2
    //{
    //    public string rel { get; set; }
    //    public string href { get; set; }
    //    public string method { get; set; }
    //    public string targetSchema { get; set; }
    //}

    public class EmailActivity
    {
        public List<Email> emails { get; set; }
        public string campaign_id { get; set; }
        public List<Link2> _links { get; set; }
        public int total_items { get; set; }
    }
}
