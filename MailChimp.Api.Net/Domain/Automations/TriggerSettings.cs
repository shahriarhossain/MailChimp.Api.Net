namespace MailChimp.Api.Net.Domain.Automations
{
    public class TriggerSettings
    {
        public string workflow_type { get; set; }
        public bool send_immediately { get; set; }
        public bool trigger_on_import { get; set; }
        public Runtime runtime { get; set; }
        public int workflow_emails_count { get; set; }
    }
}
