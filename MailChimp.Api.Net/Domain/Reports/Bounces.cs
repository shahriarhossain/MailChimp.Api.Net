using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Reports
{
    public class Bounces
    {
        public int hard_bounces { get; set; }
        public int soft_bounces { get; set; }
        public int syntax_errors { get; set; }
    }
}
