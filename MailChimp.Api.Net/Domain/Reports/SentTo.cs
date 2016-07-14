using System.Collections.Generic;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class SentTo
    {
        public string email_id { get; set; }
        public string email_address { get; set; }
        public string status { get; set; }
        public int open_count { get; set; }
        public string last_open { get; set; }
        public string absplit_group { get; set; }
        public int gmt_offset { get; set; }
        public string campaign_id { get; set; }
        public string list_id { get; set; }
        public List<Link> _links { get; set; }
    }
}
