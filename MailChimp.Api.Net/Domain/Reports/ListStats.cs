using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class ListStats
    {
        public int sub_rate { get; set; }
        public int unsub_rate { get; set; }
        public int open_rate { get; set; }
        public int click_rate { get; set; }
    }
}
