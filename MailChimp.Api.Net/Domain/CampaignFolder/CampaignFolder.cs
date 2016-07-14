using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.CampaignFolder
{
    public class CampaignFolder
    {
            public string id { get; set; }
            public string name { get; set; }
            public int count { get; set; }
            public List<Link> _links { get; set; }
    }
}
