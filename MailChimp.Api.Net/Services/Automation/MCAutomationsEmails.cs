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
    // PURPOSE     : Manage individual emails in an Automation workflow
    // ========================================================================
    internal class MCAutomationsEmails
    {
        /// <summary>
        /// Get a list of automated emails in a workflow
        /// <param name="workflow_id">Unique id for the Automation workflow</param>
        /// </summary>
        internal async Task<RootAutomationsEmail> GetAutomatedEmailListAsync(string workflow_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.automations, SubTargetType.emails, SubTargetType.not_applicable, workflow_id);

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

            return JsonConvert.DeserializeObject<RootAutomationsEmail>(content);
        }

        /// <summary>
        /// Get information about a specific workflow email
        /// <param name="workflow_id">Unique id for the Automation workflow</param>
        /// <param name="workflow_email_id">Unique id for the Automation workflow email</param>
        /// </summary>
        internal async Task<AutomationsEmail> GetInfoForSpecificWorkflowAsync(string workflow_id, string workflow_email_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.automations, SubTargetType.emails, SubTargetType.not_applicable, workflow_id, workflow_email_id);

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

            return JsonConvert.DeserializeObject<AutomationsEmail>(content);
        }


    }
}
