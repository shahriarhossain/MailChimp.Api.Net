using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class MCLocation
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int gmtoff { get; set; }
        public int dstoff { get; set; }
        public string country_code { get; set; }
        public string timezone { get; set; }
    }
}
