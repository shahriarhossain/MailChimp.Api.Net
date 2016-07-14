using System.Collections.Generic;
using MailChimp.Api.Net.Enum;

namespace MailChimp.Api.Net.Mapper
{
    internal static class EnumMapper
    {
        public static string Map(SubTargetType subType)
        {
            string subTypeValue = ActionMapper(subType);

            if (subTypeValue == SubTargetType.not_applicable.ToString())
            {
                return "";
            }
            else
            {
                string map = subTypeValue.Replace("_", "-");
                return map; 
            }  
        }

        private static string ActionMapper(SubTargetType actionType)
        {
            string mapValue;
            Dictionary<SubTargetType, string> actionMapper = new Dictionary<SubTargetType, string>()
            {
                {SubTargetType.action1, "actions/start"},
                {SubTargetType.action2, "actions/pause"},
                {SubTargetType.action3, "actions/cancel-send"},
                {SubTargetType.action4, "actions/start-all-emails"},
                {SubTargetType.action5, "actions/pause-all-emails"},
                {SubTargetType.action6, "actions/send"}
            };

            return actionMapper.TryGetValue(actionType, out mapValue) ? mapValue : actionType.ToString(); 
        }

        public static string MapTarget(TargetTypes type)
        {
            return type.ToString().Replace("_", "-");
        }
    }
}
