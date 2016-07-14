using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Automations
{
    public class RemovedSubscriber
    {
        public string workflow_id { get; set; }
        public List<Subscribers> _subscribers { get; set; }
        public int total_items { get; set; }
        public List<Link> _links { get; set; }
    }
}
