using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class MCMember
    {
        public string id { get; set; }
        public string email_address { get; set; }
        public string unique_email_id { get; set; }
        public string email_type { get; set; }
        public string status { get; set; }
        public string status_if_new { get; set; }
        //public MergeFields merge_fields { get; set; }
        public Dictionary<string, object> merge_fields { get; set; }
        public Interests interests { get; set; }
        public Stats stats { get; set; }
        public string ip_signup { get; set; }
        public string timestamp_signup { get; set; }
        public string ip_opt { get; set; }
        public string timestamp_opt { get; set; }
        public int member_rating { get; set; }
        public string last_changed { get; set; }
        public string language { get; set; }
        public bool vip { get; set; }
        public string email_client { get; set; }
        public MCLocation location { get; set; }
        public string list_id { get; set; }
        public List<Link> _links { get; set; }

      
    }
}
