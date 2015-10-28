using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MailChimp.Api.Net.Services.Reports;


using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net
{
    class Program
    {
        static void Main(string[] args)
        {         
            MCReportsCampaignAdvice ca = new MCReportsCampaignAdvice();
            var x = ca.GetAdvice("YourCampaignID").Result;


            Console.Read();
        }
    }
}
