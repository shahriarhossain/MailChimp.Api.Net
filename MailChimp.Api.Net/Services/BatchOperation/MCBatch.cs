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

        /// <summary>
        /// Get the status of a batch operation request
        /// <param name="batchId">The unique id for the batch operation</param>
        /// </summary>
       internal async Task<RootBatch> GetBatchReportById(string batchId)
       {
           string endpoint = Authenticate.EndPoint(TargetTypes.batches, SubTargetType.not_applicable, SubTargetType.not_applicable, batchId);

           return await BaseOperation.GetAsync<RootBatch>(endpoint);
       }




        /// <summary>
        /// Get a list of batch requests
        /// </summary>
        //internal async Task<T> GetAllBatchReport()
        //{
        //    string endpoint = Authenticate.EndPoint(TargetTypes.batches, SubTargetType.not_applicable, SubTargetType.not_applicable);

        //    return await BaseOperation.GetAsync<>(endpoint);
        //}
    }
}
