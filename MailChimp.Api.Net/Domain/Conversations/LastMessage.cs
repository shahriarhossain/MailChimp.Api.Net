namespace MailChimp.Api.Net.Domain.Conversations
{
    public class LastMessage
    {
        public string from_label { get; set; }
        public string from_email { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public bool read { get; set; }
        public string timestamp { get; set; }
    }
}
