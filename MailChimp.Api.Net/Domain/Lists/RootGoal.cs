using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class RootGoal
    {
        public List<Goal> goals { get; set; }
        public string list_id { get; set; }
        public string email_id { get; set; }
        public List<Link> _links { get; set; }
        public int total_items { get; set; }
    }
}
