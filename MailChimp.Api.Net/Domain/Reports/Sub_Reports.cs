using System.Collections.Generic;

namespace MailChimp.Api.Net.Domain.Reports
{
    //Earlier name of this method: RootSub_Reports
    public class Sub_Reports
    {
        public List<Report> reports { get; set; }
        public string campaign_id { get; set; }
        public List<Link2> _links { get; set; }
        public int total_items { get; set; }
    }
}
