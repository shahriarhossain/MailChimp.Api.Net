using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Automations;
using MailChimp.Api.Net.Enum;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Automation
{
    // ========================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Manage list member queues for Automation emails
    // ========================================================================
    internal class MCAutomationsEmailsQueue
    {
        /// <summary>
        /// View queued subscribers for an automated email
        /// <param name="workflow_id">Unique id for the Automation workflow</param>
        /// <param name="workflow_email_id">Unique id for the Automation workflow email</param>
        /// </summary>
        internal async Task<RootAutomationsEmailQueue> GetInfoForSpecificWorkflowAsync(string workflow_id, string workflow_email_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.automations, SubTargetType.emails, SubTargetType.queue, workflow_id, workflow_email_id);

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

            return JsonConvert.DeserializeObject<RootAutomationsEmailQueue>(content);
        }

        /// <summary>
        /// View specific subscriber in email queue
        /// <param name="workflow_id">Unique id for the Automation workflow</param>
        /// <param name="workflow_email_id">Unique id for the Automation workflow email</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address.</param>
        /// </summary>
        internal async Task<MCAutomationQueue> GetInfoForSpecificWorkflowAsync(string workflow_id, string workflow_email_id, string subscriber_hash)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.automations, SubTargetType.emails, SubTargetType.queue, workflow_id, workflow_email_id);
            endpoint = String.Format("{0}/{1}", endpoint, subscriber_hash);
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

            return JsonConvert.DeserializeObject<MCAutomationQueue>(content);
        }


    }
}
