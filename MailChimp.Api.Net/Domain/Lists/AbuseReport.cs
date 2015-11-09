using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class AbuseReport
    {
        public int id { get; set; }
        public string campaign_id { get; set; }
        public string list_id { get; set; }
        public string email_id { get; set; }
        public string email_address { get; set; }
        public string date { get; set; }
    }
}
