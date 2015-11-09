using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class CampaignDefaults
    {
        public string from_name { get; set; }
        public string from_email { get; set; }
        public string subject { get; set; }
        public string language { get; set; }
    }

   
}
