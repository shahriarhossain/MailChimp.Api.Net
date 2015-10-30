using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Campaigns
{
    public class ReportSummary
    {
        public int opens { get; set; }
        public int unique_opens { get; set; }
        public int open_rate { get; set; }
        public int clicks { get; set; }
        public int subscriber_clicks { get; set; }
        public int click_rate { get; set; }
    }
}
