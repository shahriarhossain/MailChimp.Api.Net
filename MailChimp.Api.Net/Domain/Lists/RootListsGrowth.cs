using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class RootListsGrowth
    {
        public string list_id { get; set; }
        public string month { get; set; }
        public int existing { get; set; }
        public int imports { get; set; }
        public int optins { get; set; }
        public List<Link> _links { get; set; }
    }
}
