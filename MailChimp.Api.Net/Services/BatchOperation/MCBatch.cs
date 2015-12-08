using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.BatchOperation;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.BatchOperation
{
    internal class MCBatch
    {
        /// <summary>
        /// Start a batch operation
        /// <param name="bundle"></param>
        /// </summary>
        internal async Task<dynamic> PostBatchOperationAsync(RootBatch bundle)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.batches, SubTargetType.not_applicable, SubTargetType.not_applicable);

            return await BaseOperation.PostAsync<RootBatch>(endpoint, bundle);
        }
    }
}
