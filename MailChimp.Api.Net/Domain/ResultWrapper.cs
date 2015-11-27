using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain
{
    public class ResultWrapper<T> 
    {
        public T Result { get; set; }
        public bool ErrorOccured { get; set; }
        public HttpResponseMessage ErrorObject { get; set; }
        
        public ResultWrapper(T content, bool status)
        {
            Result = content;
            ErrorOccured = status; 
        }

        public ResultWrapper(HttpResponseMessage errorObj, bool status)
        {
            ErrorObject = errorObj;
            ErrorOccured = status;
        }

    }
}
