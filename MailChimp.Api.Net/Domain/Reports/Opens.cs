using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class Opens
    {
        public int opens_total { get; set; }
        public int unique_opens { get; set; }
        public int open_rate { get; set; }
        public string last_open { get; set; }
    }
}
