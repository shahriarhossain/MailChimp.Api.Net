using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Automations
{
    public class RootAutomation
    {
        public List<MCAutomation> automations { get; set; }
        public int total_items { get; set; }
        public List<Link2> _links { get; set; }
    }
}
