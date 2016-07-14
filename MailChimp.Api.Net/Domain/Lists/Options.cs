using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Campaigns;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class Options
    {
        public int size { get; set; }
        public string match { get; set; }
        public List<Condition> conditions { get; set; }
    }
}
