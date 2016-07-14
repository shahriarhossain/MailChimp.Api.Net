using System.Collections.Generic;

namespace MailChimp.Api.Net.Domain.Campaigns
{
    public class VariateSettings
    {
        public string winning_combination_id { get; set; }
        public string winning_campaign_id { get; set; }
        public string winner_criteria { get; set; }
        public int wait_time { get; set; }
        public int test_size { get; set; }
        public List<string> subject_lines { get; set; }
        public List<string> send_times { get; set; }
        public List<string> from_names { get; set; }
        public List<string> reply_to_addresses { get; set; }
        public List<object> contents { get; set; }
        public List<Combination> combinations { get; set; }
    }
}
