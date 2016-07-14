using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Automations
{
    public class RootAutomationsEmail
    {
        public string workflow_id { get; set; }
        public List<AutomationsEmail> emails { get; set; }
        public int total_items { get; set; }
        public List<Link2> _links { get; set; }
    }
}
