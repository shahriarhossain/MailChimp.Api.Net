using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class Activity
    {
        public string action { get; set; }
        public string timestamp { get; set; }
        public string ip { get; set; }
    }
}
