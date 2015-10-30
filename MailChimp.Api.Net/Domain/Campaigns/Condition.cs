using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Campaigns
{
    public class Condition
    {
        public string field { get; set; }
        public string op { get; set; }
        public int value { get; set; }
    }
}
