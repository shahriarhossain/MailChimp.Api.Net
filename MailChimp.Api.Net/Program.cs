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
            ReportsOverview rep = new ReportsOverview();
            var x = rep.OverviewAsync();
            Console.ReadKey();
            
            ReportOverview s = rep.OverviewAsync();
            
            //e6e1eb2be8
            ReportOverview_CampaignSpecific d = rep.CampaignSpecificOverviewAsync("e6e1eb2be8").Result;
            Console.ReadKey();

            Console.Read();
        }
    }
}
