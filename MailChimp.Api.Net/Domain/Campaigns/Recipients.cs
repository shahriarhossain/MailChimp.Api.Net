using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Campaigns
{
    public class Recipients
    {
        public string list_id { get; set; }
        public string segment_text { get; set; }
        public SegmentOpts segment_opts { get; set; }
    }
}
