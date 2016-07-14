namespace MailChimp.Api.Net.Domain.Reports
{
    public class Timesery
    {
        public string timestamp { get; set; }
        public int emails_sent { get; set; }
        public int unique_opens { get; set; }
        public int recipients_clicks { get; set; }
    }
}
