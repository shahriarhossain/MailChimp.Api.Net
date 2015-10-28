using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{
     public class Unsubscribe
    {
        public string email_id { get; set; }
        public string email_address { get; set; }
        public string timestamp { get; set; }
        public string reason { get; set; }
        public string campaign_id { get; set; }
        public string list_id { get; set; }
        public List<Link> _links { get; set; }
    }
}
