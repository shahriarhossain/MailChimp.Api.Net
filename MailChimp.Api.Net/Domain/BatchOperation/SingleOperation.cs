using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.BatchOperation
{
    public class SingleOperation
    {
        public string method { get; set; }
        public string path{ get; set; }
        public string body { get; set; }
        public string operation_id { get; set; }
    }
}
