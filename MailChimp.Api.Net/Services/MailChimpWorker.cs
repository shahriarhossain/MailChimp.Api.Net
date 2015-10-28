using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using MailChimp.Api.Net.Enum;

namespace MailChimp.Api.Net.Services
{
    public static class MailChimpWorker
    {
        public static async Task<string> Execute(Method method, string endpoint)
        {
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                return await client.GetStringAsync(endpoint);
            }
        }
    }
}
