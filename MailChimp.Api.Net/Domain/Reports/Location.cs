using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class Location
    {
        public string country_code { get; set; }
        public string region { get; set; }
        public int opens { get; set; }
    }

    //public class Link
    //{
    //    public string rel { get; set; }
    //    public string href { get; set; }
    //    public string method { get; set; }
    //    public string targetSchema { get; set; }
    //}

    public class RootLocation
    {
        public List<Location> locations { get; set; }
        public string campaign_id { get; set; }
        public List<Link> _links { get; set; }
        public int total_items { get; set; }
    }
}
