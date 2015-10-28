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
        public double emails_pct { get; set; }
        public int bounces_pct { get; set; }
        public int opens_pct { get; set; }
        public int clicks_pct { get; set; }
        public int unsubs_pct { get; set; }
    }
}
