using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.CampaignFolder
{
    public class RootCampaignFolder
    {
        public List<CampaignFolder> folders { get; set; }
        public int total_items { get; set; }
        public List<Link2> _links { get; set; }
    }
}
