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

      string map = subTypeValue.Replace("_", "-");
      return map;
    }

    private static string ActionMapper(SubTargetType actionType)
    {
      string mapValue;
      Dictionary<SubTargetType, string> actionMapper = new Dictionary<SubTargetType, string>
        {
          {SubTargetType.actionStart, "actions/start"},
          {SubTargetType.actionPause, "actions/pause"},
          {SubTargetType.actionCancelSend, "actions/cancel-send"},
          {SubTargetType.actionStartAllEmails, "actions/start-all-emails"},
          {SubTargetType.actionPauseAllEmails, "actions/pause-all-emails"},
          {SubTargetType.actionSend, "actions/send"},
          {SubTargetType.actionTest, "actions/test"}
        };

      return actionMapper.TryGetValue(actionType, out mapValue) ? mapValue : actionType.ToString();
    }

    public static string MapTarget(TargetTypes type)
    {
      return type.ToString().Replace("_", "-");
    }
  }
}