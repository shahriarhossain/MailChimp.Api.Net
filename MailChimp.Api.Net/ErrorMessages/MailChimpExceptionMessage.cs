using System;
using MailChimp.Api.Net.Enum;

namespace MailChimp.Api.Net.ErrorMessages
{
    internal static class MailChimpExceptionMessage
    {
        public static string NullOrEmptyMessage(CommandProperty command)
        {
            return String.Format("{0} is NULL or empty", command.ToString());
        }

        public static string InvalidMessage(CommandProperty command)
        {
            return String.Format("{0} is Invalid", command.ToString());
        }
    }
}
