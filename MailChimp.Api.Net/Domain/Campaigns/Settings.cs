namespace MailChimp.Api.Net.Domain.Campaigns
{
    public class Settings
    {
        public string subject_line { get; set; }
        public string title { get; set; }
        public string from_name { get; set; }
        public string reply_to { get; set; }
        public bool use_conversation { get; set; }
        public string to_name { get; set; }
        public int? folder_id { get; set; }
        public bool authenticate { get; set; }
        public bool auto_footer { get; set; }
        public bool inline_css { get; set; }
        public bool auto_tweet { get; set; }
        public bool fb_comments { get; set; }
        public bool timewarp { get; set; }
        public int template_id { get; set; }
        public bool drag_and_drop { get; set; }
    }
}
