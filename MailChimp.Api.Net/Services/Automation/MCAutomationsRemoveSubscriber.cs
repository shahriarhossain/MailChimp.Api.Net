using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Automations;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Automation
{
    // ========================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Remove subscribers from an Automation workflow.
    // ========================================================================
    internal class MCAutomationsRemoveSubscriber
    {
        /// <summary>
        /// View all subscribers removed from a workflow
        /// <param name="workflow_id">Unique id for the Automation workflow</param>
        /// </summary>
        internal async Task<RemovedSubscriber> GetRemovedSubscriberListAsync(string workflow_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.automations, SubTargetType.removed_subscribers, SubTargetType.not_applicable, workflow_id);

            return await BaseOperation.GetAsync<RemovedSubscriber>(endpoint);
        }

    }
}
