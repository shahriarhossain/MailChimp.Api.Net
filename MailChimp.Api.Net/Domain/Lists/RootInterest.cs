using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Lists
{
    class RootInterest
    {
        public List<Interest> interests { get; set; }
        public string list_id { get; set; }
        public string category_id { get; set; }
        public List<Link2> _links { get; set; }
        public int total_items { get; set; }
    }
}
