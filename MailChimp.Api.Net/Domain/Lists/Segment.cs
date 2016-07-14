using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class Segment
    {
        public int id { get; set; }
        public string name { get; set; }
        public int member_count { get; set; }
        public string type { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public Options options { get; set; }
        public string list_id { get; set; }
        public List<Link> _links { get; set; }
    }
}
