using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.ErrorMessages;

namespace MailChimp.Api.Net.CustomException
{
    public class MailChimpExceptions : Exception
    {
        public MailChimpExceptions(string msg): base(msg)
        {
            
        }
    }
}
