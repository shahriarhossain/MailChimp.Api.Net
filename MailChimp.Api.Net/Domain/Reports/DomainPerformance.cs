using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class Domain
    {
        public string domain { get; set; }
        public int emails_sent { get; set; }
        public int bounces { get; set; }
        public int opens { get; set; }
        public int clicks { get; set; }
        public int unsubs { get; set; }
        public int delivered { get; set; }
        public int emails_pct { get; set; }
        public int bounces_pct { get; set; }
        public int opens_pct { get; set; }
        public int clicks_pct { get; set; }
        public int unsubs_pct { get; set; }
    }

    //public class Link
    //{
    //    public string rel { get; set; }
    //    public string href { get; set; }
    //    public string method { get; set; }
    //    public string targetSchema { get; set; }
    //}

    public class DomainPerformance
    {
        public List<Domain> domains { get; set; }
        public int total_sent { get; set; }
        public string campaign_id { get; set; }
        public List<Link> _links { get; set; }
        public int total_items { get; set; }
    }
}
