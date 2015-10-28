using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class FacebookLikes
    {
        public int recipient_likes { get; set; }
        public int unique_likes { get; set; }
        public int facebook_likes { get; set; }
    }
}
