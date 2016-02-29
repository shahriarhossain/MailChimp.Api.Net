using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.BatchOperation
{
    public class MultiOperation
    {
        public List<RootBatch> batches { get; set; }
        public int totalItems {get; set; }
    }
}
