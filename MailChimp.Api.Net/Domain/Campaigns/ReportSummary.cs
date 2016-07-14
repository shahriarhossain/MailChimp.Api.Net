namespace MailChimp.Api.Net.Domain.Campaigns
{
    public class ReportSummary
    {
        public int opens { get; set; }
        public int unique_opens { get; set; }
        public double open_rate { get; set; }
        public int clicks { get; set; }
        public int subscriber_clicks { get; set; }
        public double click_rate { get; set; }
    }
}
