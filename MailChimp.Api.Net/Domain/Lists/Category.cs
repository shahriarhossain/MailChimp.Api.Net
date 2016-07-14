using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class Category
    {
        public string list_id { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public int display_order { get; set; }
        public string type { get; set; }
        public List<Link> _links { get; set; }
    }
}
