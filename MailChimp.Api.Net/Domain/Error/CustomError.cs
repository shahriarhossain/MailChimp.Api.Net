using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Error
{
    public class CustomError : HttpResponseMessage
    {
        public bool PostStatus { get; set; }
    }
}
