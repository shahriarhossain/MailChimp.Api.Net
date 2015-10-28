using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Enum;

namespace MailChimp.Api.Net.Mapper
{
    public static class EnumMapper
    {
        public static string Map(SubTargetType subType)
        {
            if (subType == SubTargetType.not_applicable)
            {
                return "";
            }
            else
            {
                string map = subType.ToString().Replace("_", "-");
                return map; 
            }
            
        }
    }
}
