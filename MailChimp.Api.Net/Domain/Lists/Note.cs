using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class Note
    {
        public int id { get; set; }
        public string created_at { get; set; }
        public string created_by { get; set; }
        public string updated_at { get; set; }
        public string note { get; set; }
        public string list_id { get; set; }
        public string email_id { get; set; }
        public List<Link> _links { get; set; }
    }
}
