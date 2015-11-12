using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;
using MailChimp.Api.Net.Enum;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Reports
{
    // ==================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Get list member activity for a specific campaign. 
    // ==================================================================

    internal class MCReportsEmailActivity
    {
        /// <summary>
        /// Return list member activity for a specific campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// </summary>
        internal async Task<EmailActivity> GetEmailActivityAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.email_activity, SubTargetType.not_applicable, campaignId);
            
            //Temporary start
            endpoint = String.Format("{0}?count={1}", endpoint, 423);
            //Temporary end 

            string content;
            using (var client = new HttpClient())
            {
                try
                {
                    Authenticate.ClientAuthentication(client);

                    content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    throw ex;
                }  
            }

            return JsonConvert.DeserializeObject<EmailActivity>(content);
        }

        /// <summary>
        /// Return list member activity for a specific campaign
        /// <param name="campaignId">Unique id for the campaign</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
        /// </summary>
        internal async Task<EmailActivity> GetSubscriberSpecificEmailActivityAsync(string campaignId, string subscriber_hash)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.email_activity, SubTargetType.not_applicable, campaignId, subscriber_hash);

            string content;
            using (var client = new HttpClient())
            {
                try
                {
                    Authenticate.ClientAuthentication(client);

                    content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    throw;
                } 
            }

            return JsonConvert.DeserializeObject<EmailActivity>(content);
        }
    }
}
