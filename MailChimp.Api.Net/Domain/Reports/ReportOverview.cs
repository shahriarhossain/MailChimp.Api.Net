using System.Collections.Generic;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class ReportOverview
    {
        public List<Report> reports { get; set; }
        public List<Link2> _links { get; set; }
        public int total_items { get; set; }
    }
}
