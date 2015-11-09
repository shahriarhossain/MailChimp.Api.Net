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
    // ==================================================================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     :  Use the Automation API calls to manage Automation workflows, emails, and queues.
    // ===================================================================================================================================================
    internal class MCAutomationsOverview
    {
        /// <summary>
        /// Get a list of Automations
        /// </summary>
        internal async Task<RootAutomation> GetAllAutomationListsAsync()
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.automations, SubTargetType.not_applicable, SubTargetType.not_applicable);

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

            return JsonConvert.DeserializeObject<RootAutomation>(content);
        }

        /// <summary>
        /// Get information about a specific Automation workflow
        /// <param name="workflow_id">Unique id for the Automation workflow</param>
        /// </summary>
        internal async Task<MCAutomation> GetInfoByWorkflowIdAsync(string workflow_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.automations, SubTargetType.not_applicable, SubTargetType.not_applicable, workflow_id);

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

            return JsonConvert.DeserializeObject<MCAutomation>(content);
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
