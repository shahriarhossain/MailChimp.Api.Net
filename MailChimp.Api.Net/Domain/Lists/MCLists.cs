using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class MCLists
    {
        public string id { get; set; }
        public string name { get; set; }
        public Contact contact { get; set; }
        public string permission_reminder { get; set; }
        public bool use_archive_bar { get; set; }
        public CampaignDefaults campaign_defaults { get; set; }
        public string notify_on_subscribe { get; set; }
        public string notify_on_unsubscribe { get; set; }
        public string date_created { get; set; }
        public int list_rating { get; set; }
        public bool email_type_option { get; set; }
        public string subscribe_url_short { get; set; }
        public string subscribe_url_long { get; set; }
        public string beamer_address { get; set; }
        public string visibility { get; set; }
        public List<object> modules { get; set; }
        public MCListStats stats { get; set; }
        public List<Link> _links { get; set; }
    }
}
