using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class LastNote
    {
        public int note_id { get; set; }
        public string created_at { get; set; }
        public string created_by { get; set; }
        public string note { get; set; }
    }
}
