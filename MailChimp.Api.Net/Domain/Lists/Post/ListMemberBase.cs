using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Lists.Post
{
    public class ListMemberBase
    {
        public string email_type { get; set; }
        public string status { get; set; }
        public string language { get; set; }
        public string email_address { get; set; }
    }
}
