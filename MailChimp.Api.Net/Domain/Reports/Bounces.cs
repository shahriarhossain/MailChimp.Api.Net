namespace MailChimp.Api.Net.Domain.Reports
{
    public class Bounces
    {
        public double hard_bounces { get; set; }
        public double soft_bounces { get; set; }
        public double syntax_errors { get; set; }
    }
}
