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
        public int click_rate { get; set; }
        public string last_click { get; set; }
    }
}
