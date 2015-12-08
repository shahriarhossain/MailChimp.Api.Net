using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain
{
    public class ResultWrapper<T>
    {
        public T Result { get; set; }
        public bool HasError { get; set; }
        public HttpResponseMessage ErrorObject { get; set; }

        public ResultWrapper(T content, bool hasError)
        {
            Result = content;
            HasError = hasError;
        }

        public ResultWrapper(HttpResponseMessage errorObj, bool hasError)
        {
            ErrorObject = errorObj;
            HasError = hasError;
        }
    }

    public class ResultWrapper : DynamicObject
    {
        public bool HasError { get; set; }
        public bool IsSuccess { get; set; }
        public string SuccessMessage { get; set; }
        public HttpResponseMessage ErrorObject { get; set; }

        public ResultWrapper(bool hasError)
        {
            IsSuccess = true;
            SuccessMessage = "Request Successful.";
            HasError = hasError;
        }

        public ResultWrapper(HttpResponseMessage errorObj, bool hasError)
        {
            ErrorObject = errorObj;
            HasError = hasError;
        }
    }
}
