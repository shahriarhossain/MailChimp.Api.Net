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
    private MCAutomationsOverview overview;
    private MCAutomationsEmails automationsemails;
    private MCAutomationsEmailsQueue emailQueue;
    private MCAutomationsRemoveSubscriber removedSubscriber;

    public MailChimpAutomation()
    {
      overview = new MCAutomationsOverview();
      automationsemails = new MCAutomationsEmails();
      emailQueue = new MCAutomationsEmailsQueue();
      removedSubscriber = new MCAutomationsRemoveSubscriber();
    }

    #region overview

    /// <summary>
    /// Get a summary of an account’s Automations
    /// </summary>
    public async Task<RootAutomation> GetAllAutomationsAsync()
    {
      return await overview.GetAllAutomationsAsync();
    }

    /// <summary>
    /// Get information about a specific Automation workflow
    /// <param name="workflow_id">Unique id for the Automation workflow</param>
    /// </summary>
    public async Task<MCAutomation> GetAutomationAsync(string workflow_id)
    {
      return await overview.GetAutomationAsync(workflow_id);
    }

    #endregion overview

    #region automation emails

    /// <summary>
    /// Get a list of automated emails in a workflow
    /// <param name="workflow_id">Unique id for the Automation workflow</param>
    /// </summary>
    public async Task<RootAutomationsEmail> GetAutomationEmailsAsync(string workflow_id)
    {
      return await automationsemails.GetAutomationEmailsAsync(workflow_id);
    }

    /// <summary>
    /// Get information about a specific workflow email
    /// <param name="workflow_id">Unique id for the Automation workflow</param>
    /// <param name="workflow_email_id">Unique id for the Automation workflow email</param>
    /// </summary>
    public async Task<AutomationsEmail> GetAutomationEmailInfoAsync(string workflow_id, string workflow_email_id)
    {
      return await automationsemails.GetAutomationEmailInfoAsync(workflow_id, workflow_email_id);
    }

    #endregion automation emails

    #region emailQueue

    /// <summary>
    /// View queued subscribers for an automated email
    /// <param name="workflow_id">Unique id for the Automation workflow</param>
    /// <param name="workflow_email_id">Unique id for the Automation workflow email</param>
    /// </summary>
    public async Task<RootAutomationsEmailQueue> GetQueuedSubscriberListAsync(string workflow_id, string workflow_email_id)
    {
      return await emailQueue.GetQueuedSubscriberListAsync(workflow_id, workflow_email_id);
    }

    /// <summary>
    /// View specific subscriber in email queue
    /// <param name="workflow_id">Unique id for the Automation workflow</param>
    /// <param name="workflow_email_id">Unique id for the Automation workflow email</param>
    /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address.</param>
    /// </summary>
    public async Task<MCAutomationQueue> GetSubscriberInQueueAsync(string workflow_id, string workflow_email_id,
                                                                        string subscriber_hash)
    {
      return await emailQueue.GetSubscriberInQueueAsync(workflow_id, workflow_email_id, subscriber_hash);
    }

    #endregion emailQueue

    #region removedSubscriber

    /// <summary>
    /// View all subscribers removed from a workflow
    /// <param name="workflow_id">Unique id for the Automation workflow</param>
    /// </summary>
    public async Task<RemovedSubscriber> GetRemovedSubscriberListAsync(string workflow_id)
    {
      return await removedSubscriber.GetRemovedSubscriberListAsync(workflow_id);
    }

    #endregion removedSubscriber
  }
}