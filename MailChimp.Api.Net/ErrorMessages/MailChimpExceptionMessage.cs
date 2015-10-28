using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MailChimp.Api.Net.Enum;

namespace MailChimp.Api.Net.ErrorMessages
{
    public static class MailChimpExceptionMessage
    {
        public static string NullOrEmptyMessage(CommandProperty command)
        {
            return String.Format("{0} is NULL or empty", command.ToString());
        }

        public static string InvalidMessage(CommandProperty command)
        {
            return String.Format("{0} is Invalid", command.ToString());
        }

        public static string UnknownExceptionMessage(Exception ex)
        {
            return String.Format("Exception Occured : {0}", ex.ToString());
        }
    }
}
