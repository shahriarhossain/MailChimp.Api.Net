using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class EmailActivity
    {
        public List<Email> emails { get; set; }
        public string campaign_id { get; set; }
        public List<Link2> _links { get; set; }
        public int total_items { get; set; }
    }
}
