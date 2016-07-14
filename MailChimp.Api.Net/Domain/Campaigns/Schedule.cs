using System;

namespace MailChimp.Api.Net.Domain.Campaigns
{
    public class Schedule
    {
        public string apikey { get; set; }
        public string cid { get; set; }
        public DateTime schedule_time { get; set; }
        public DateTime? schedule_time_b { get; set; }
    }    
}
