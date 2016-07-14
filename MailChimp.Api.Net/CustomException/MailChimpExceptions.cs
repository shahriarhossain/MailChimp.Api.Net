using System;

namespace MailChimp.Api.Net.CustomException
{
    internal class MailChimpExceptions : Exception
    {
        public MailChimpExceptions(string msg): base(msg)
        {
            
        }

        //public MailChimpExceptions(string msg, NullReferenceException ex)
        //    : base(msg, ex)
        //{
        //    return String.Format("MailChimp API Key missing! To resolve Add a key named 'MailChimpApiKey' in your config and SET its value with your mailchimp API key!");
        //}

    }
}
