using System;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Automations;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Automation
{
    // ==================================================================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     :  Use the Automation API calls to manage Automation workflows, emails, and queues.
    // ===================================================================================================================================================
    internal class MCAutomationsOverview
    {
        /// <summary>
        /// Get a list of Automations
        /// </summary>
        internal async Task<RootAutomation> GetAllAutomationListsAsync(int count=10)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.automations, SubTargetType.not_applicable, SubTargetType.not_applicable);
            endpoint = String.Format("{0}?count={1}", endpoint, count);
            return await BaseOperation.GetAsync<RootAutomation>(endpoint);
        }

        /// <summary>
        /// Get information about a specific Automation workflow
        /// <param name="workflow_id">Unique id for the Automation workflow</param>
        /// </summary>
        internal async Task<MCAutomation> GetInfoByWorkflowIdAsync(string workflow_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.automations, SubTargetType.not_applicable, SubTargetType.not_applicable, workflow_id);

            return await BaseOperation.GetAsync<MCAutomation>(endpoint);
        }

        /// <summary>
        /// Pause all emails in an Automation workflow
        /// <param name="workflow_id">Unique id for the Automation workflow</param>
        /// </summary>
            
        //internal async Task<MCAutomation> PauseAllEmailInWorkflowAsync(string workflow_id)
        //{
        //    string endpoint = Authenticate.EndPoint(TargetTypes.automations, SubTargetType.action5, SubTargetType.not_applicable, workflow_id);

            
        //}

    }
}
