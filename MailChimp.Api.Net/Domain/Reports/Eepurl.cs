using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class Eepurl
    {
        public Clicks clicks { get; set; }
        public string eepurl { get; set; }
        public string campaign_id { get; set; }
        public List<Link> _links { get; set; }
        public int total_items { get; set; }
    }
}
