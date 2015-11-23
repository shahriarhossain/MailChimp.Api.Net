using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Automations
{
    public class Subscribers
    {
        public string id { get; set; }
        public string workflow_id { get; set; }
        public string list_id { get; set; }
        public string emails_sent { get; set; }
        public List<Link> _links { get; set; }
    }
}
