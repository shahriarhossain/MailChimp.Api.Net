using System.Collections.Generic;

namespace MailChimp.Api.Net.Domain.BatchOperation
{
    public class MultiOperation
    {
        public List<RootBatch> batches { get; set; }
        public int totalItems {get; set; }
    }
}
