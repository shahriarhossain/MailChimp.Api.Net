using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.BatchOperation;
using MailChimp.Api.Net.Domain.Lists.Post;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MailChimp.Api.Net.Helper
{
    internal static class  BundleCreation
    {
        RootBatch bundle = new RootBatch();
        
        SingleOperation bundleElement = new SingleOperation();
      
        public RootBatch CreateBundle(List<ListMemberBase> members, Method method, string endPoint )
        { 
            foreach (var item in members)
            {
                bundleElement.method = method.ToString();
                bundleElement.path = endPoint;
                bundleElement.body = JsonConvert.SerializeObject(item);
                bundle.bundles.Add(bundleElement);
            }

            return bundle;
        }

    }
}
