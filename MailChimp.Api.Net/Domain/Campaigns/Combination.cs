namespace MailChimp.Api.Net.Domain.Campaigns
{
    public class Combination
    {
        public string id { get; set; }
        public int subject_line { get; set; }
        public int send_time { get; set; }
        public int from_name { get; set; }
        public int reply_to { get; set; }
        public int content_description { get; set; }
        public int recipients { get; set; }
    }
}
