using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Automations;

namespace MailChimp.Api.Net.Services.Automation
{
    // ===============================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Use the Automation API calls to manage Automation workflows, emails, and queues.
    // ===============================================================================================
    public class MailChimpAutomation
    {
        MCAutomationsOverview overview;
        MCAutomationsEmails automationsemails;
        MCAutomationsEmailsQueue emailQueue;
        MCAutomationsRemoveSubscriber removedSubscriber;

        public MailChimpAutomation()
        {
            overview = new MCAutomationsOverview();
            automationsemails = new MCAutomationsEmails();
            emailQueue = new MCAutomationsEmailsQueue();
            removedSubscriber = new MCAutomationsRemoveSubscriber();
        }

        #region overview
        /// <summary>
        /// Get a list of Automations
        /// </summary>
        public async Task<RootAutomation> GetAutomationListAsync(int count = 10)
        {
            return await overview.GetAllAutomationListsAsync(count);
        }

        /// <summary>
        /// Get information about a specific Automation workflow
        /// <param name="workflow_id">Unique id for the Automation workflow</param>
        /// </summary>
        internal async Task<MCAutomation> GetSpecificAutomationAsync(string workflow_id)
        {
            return await overview.GetInfoByWorkflowIdAsync(workflow_id);
        }

        #endregion overview

        #region automationsemails
        /// <summary>
        /// Get a list of automated emails in a workflow
        /// <param name="workflow_id">Unique id for the Automation workflow</param>
        /// </summary>
        internal async Task<RootAutomationsEmail> GetAutomatedEmailListAsync(string workflow_id)
        {
            return await automationsemails.GetAutomatedEmailListAsync(workflow_id);
        }

        /// <summary>
        /// Get information about a specific workflow EMAIL
        /// <param name="workflow_id">Unique id for the Automation workflow</param>
        /// <param name="workflow_email_id">Unique id for the Automation workflow email</param>
        /// </summary>
        internal async Task<AutomationsEmail> GetInfoForSpecificWorkflowEmailAsync(string workflow_id, string workflow_email_id)
        {
            return await automationsemails.GetInfoForSpecificWorkflowEmailAsync(workflow_id, workflow_email_id);
        }
        #endregion automationsemails

        #region emailQueue
        /// <summary>
        /// View queued subscribers for an automated email
        /// <param name="workflow_id">Unique id for the Automation workflow</param>
        /// <param name="workflow_email_id">Unique id for the Automation workflow email</param>
        /// </summary>
        internal async Task<RootAutomationsEmailQueue> GetQueuedSubscriberListAsync(string workflow_id, string workflow_email_id)
        {
            return await emailQueue.GetQueuedSubscriberListAsync(workflow_id, workflow_email_id);
        }

        /// <summary>
        /// View specific subscriber in email queue
        /// <param name="workflow_id">Unique id for the Automation workflow</param>
        /// <param name="workflow_email_id">Unique id for the Automation workflow email</param>
        /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address.</param>
        /// </summary>
        internal async Task<MCAutomationQueue> GetSpecificSubscriberInQueueAsync(string workflow_id, string workflow_email_id, string subscriber_hash)
        {
            return await emailQueue.GetSpecificSubscriberInQueueAsync(workflow_id, workflow_email_id, subscriber_hash);
        }

        #endregion emailQueue

        #region removedSubscriber
        /// <summary>
        /// View all subscribers removed from a workflow
        /// <param name="workflow_id">Unique id for the Automation workflow</param>
        /// </summary>
        internal async Task<RemovedSubscriber> GetRemovedSubscriberListAsync(string workflow_id)
        {
            return await removedSubscriber.GetRemovedSubscriberListAsync(workflow_id);
        }
        #endregion removedSubscriber
    }
}
