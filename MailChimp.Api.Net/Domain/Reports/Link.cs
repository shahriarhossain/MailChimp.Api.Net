using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class Link
    {
        public string rel { get; set; }
        public string href { get; set; }
        public string method { get; set; }
        public string targetSchema { get; set; }
        public string schema { get; set; }
    }
}
