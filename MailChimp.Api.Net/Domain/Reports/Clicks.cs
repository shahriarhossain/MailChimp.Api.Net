using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class Clicks
    {
        public int clicks_total { get; set; }
        public int unique_clicks { get; set; }
        public int unique_subscriber_clicks { get; set; }
        public double click_rate { get; set; }
        public string last_click { get; set; }

        public int clicks { get; set; }
        public string first_click { get; set; }
        public List<object> locations { get; set; }
    }
}
