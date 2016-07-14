using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Automations
{
    public class RootAutomationsEmailQueue
    {
        public string workflow_id { get; set; }
        public string email_id { get; set; }
        public List<MCAutomationQueue> queue { get; set; }
        public int total_items { get; set; }
        public List<Link2> _links { get; set; }
    }
}
