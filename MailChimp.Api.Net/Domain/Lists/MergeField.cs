using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class MergeField
    {
        public int merge_id { get; set; }
        public string tag { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public bool required { get; set; }
        public string default_value { get; set; }
        public bool @public { get; set; }
        public int display_order { get; set; }
        public Options options { get; set; }
        public string help_text { get; set; }
        public string list_id { get; set; }
        public List<Link> _links { get; set; }
    }

}
