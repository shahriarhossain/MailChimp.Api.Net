using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class MCClient
    {
        public string client { get; set; }
        public int members { get; set; }
        public string list_id { get; set; }
    }
}
