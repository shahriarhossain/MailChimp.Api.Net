using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class UrlsClicked
    {
        public string id { get; set; }
        public string url { get; set; }
        public int total_clicks { get; set; }
        public double click_percentage { get; set; }
        public int unique_clicks { get; set; }
        public double unique_click_percentage { get; set; }
        public string last_click { get; set; }
        public string campaign_id { get; set; }
        public List<Link> _links { get; set; }
    }
}
