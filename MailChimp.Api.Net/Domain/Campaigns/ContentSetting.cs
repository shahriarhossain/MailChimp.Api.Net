using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Campaigns
{
    public class ContentSetting
    {
        public string plain_text { get; set; }
        public string html { get; set; }
        public string url { get; set; }
    }
}
