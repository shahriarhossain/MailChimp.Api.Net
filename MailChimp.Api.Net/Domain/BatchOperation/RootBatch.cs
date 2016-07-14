using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.BatchOperation
{
    public class RootBatch
    {
        public List<SingleOperation> operations;

        public RootBatch()
        {
            operations = new List<SingleOperation>();
        }

        public string id { get; set; }
        public string status { get; set; }
        public int total_operations { get; set; }
        public int finished_operations { get; set; }
        public int errored_operations { get; set; }
        public string submitted_at { get; set; }
        public string completed_at { get; set; }
        public string response_body_url { get; set; }
        public List<Link> _links { get; set; }
    }
}
