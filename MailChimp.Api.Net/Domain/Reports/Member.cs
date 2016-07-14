namespace MailChimp.Api.Net.Domain.Reports
{
    public class Member
    {
        public string email_id { get; set; }
        public string email_address { get; set; }
        public int clicks { get; set; }
        public string campaign_id { get; set; }
        public string url_id { get; set; }
        public string list_id { get; set; }
    }
}
