using System;
using System.Collections.Generic;
using System.Linq;

namespace MailChimp.Api.Net.Services.Reports
{
    internal class MCReportsExtension
    {
        public void SubscriberWithMostOpen()
        {
            MailChimpReports reports = new MailChimpReports();
            var x = reports.GetEmailActivityAsync("3709ea682b").Result;

            var emailCount = x.emails.Count;
            Dictionary<string, int> activityList = new Dictionary<string, int>();
            foreach (var item in x.emails)
            {
                var activityCount = item.activity.Count;
                int countOpen = 0;

                foreach (var item2 in item.activity)
                {
                    if (item2.action == "open")
                    {
                        countOpen += 1;
                    }
                }
                string emailAdd = item.email_address.ToString();
                activityList.Add(emailAdd, countOpen);
            }

            var sortedList = from temp in activityList
                             orderby temp.Value descending
                             select temp;

            sortedList.ToList();

            Console.Write("TOP 5 Open are : \n");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sortedList.ElementAt(i).Key + " : " + sortedList.ElementAt(i).Value);
            }
        }
    }
}
