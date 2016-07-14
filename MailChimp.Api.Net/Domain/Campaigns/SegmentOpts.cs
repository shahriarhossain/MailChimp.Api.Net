using System.Collections.Generic;

namespace MailChimp.Api.Net.Domain.Campaigns
{
    public class SegmentOpts
    {
        public int saved_segment_id { get; set; }
        public string match { get; set; }
        public List<Condition> conditions { get; set; }
    }
}
