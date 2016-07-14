using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Campaigns
{
    public class RootContent
    {
            public string plain_text { get; set; }
            public string html { get; set; }
            public List<Link> _links { get; set; }

            public string url { get; set; }
            public ContentTemplate template { get; set; }
            //public ArchiveContent archive {get; set; }
    }
}
