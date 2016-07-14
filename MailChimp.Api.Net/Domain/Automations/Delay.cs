namespace MailChimp.Api.Net.Domain.Automations
{
    public class Delay
    {
        public int amount { get; set; }
        public string type { get; set; }
        public string direction { get; set; }
        public string action { get; set; }
    }
}
