namespace MailChimp.Api.Net.Domain.Reports
{
    public class Opens
    {
        public int opens_total { get; set; }
        public int unique_opens { get; set; }
        public double open_rate { get; set; }
        public string last_open { get; set; }
    }
}
