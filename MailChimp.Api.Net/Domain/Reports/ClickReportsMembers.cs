using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class Member
    {
        public string email_id { get; set; }
        public string email_address { get; set; }
        public int clicks { get; set; }
        public string campaign_id { get; set; }
        public string url_id { get; set; }
        public string list_id { get; set; }
    }

    //public class Link
    //{
    //    public string rel { get; set; }
    //    public string href { get; set; }
    //    public string method { get; set; }
    //    public string targetSchema { get; set; }
    //}

    public class ClickReportsMembers
    {
        public List<Member> members { get; set; }
        public string campaign_id { get; set; }
        public List<Link> _links { get; set; }
        public int total_items { get; set; }
    }

}
