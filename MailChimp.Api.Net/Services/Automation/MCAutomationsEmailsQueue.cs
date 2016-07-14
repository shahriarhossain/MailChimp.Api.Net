using System;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Automations;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

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
        internal async Task<RootAutomationsEmailQueue> GetQueuedSubscriberListAsync(string workflow_id, string workflow_email_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.automations, SubTargetType.emails, SubTargetType.queue, workflow_id, workflow_email_id);

            return await BaseOperation.GetAsync<RootAutomationsEmailQueue>(endpoint);
        }

        /// <summary>
        /// View specific subscriber in email queue
        /// <param name="workflow_id">Unique id for the Automation workflow</param>
        /// <param name="workflow_email_id">Unique id for the Automation workflow email</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address.</param>
        /// </summary>
        internal async Task<MCAutomationQueue> GetSpecificSubscriberInQueueAsync(string workflow_id, string workflow_email_id, string subscriber_hash)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.automations, SubTargetType.emails, SubTargetType.queue, workflow_id, workflow_email_id);
            endpoint = String.Format("{0}/{1}", endpoint, subscriber_hash);

            return await BaseOperation.GetAsync<MCAutomationQueue>(endpoint);
        }


    }
}
