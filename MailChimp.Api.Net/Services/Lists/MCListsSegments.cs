using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Lists;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Lists
{
  // ==================================================================
  // AUTHOR      : Shahriar Hossain
  // PURPOSE     : Manage segments for a specific MailChimp list.
  // ==================================================================

  internal class MCListsSegments
  {
    /// <summary>
    /// Create a new segment in a specific list
    /// <param name="name">The name of the segment.</param>
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="static_segment">An array of emails to be used for a static segment. Any emails provided that are not present on the list will be ignored. Passing an empty array will create a static segment without any subscribers. This field cannot be provided with the options field.</param>
    /// </summary>
    internal async Task<dynamic> AddSegmentAsync(string name, string list_id, List<string> static_segment)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.segments, SubTargetType.not_applicable,
                                              list_id);
      Segment segment = new Segment
        {
          name = name,
          static_segment = static_segment
        };

      return await BaseOperation.PostAsync<Segment>(endpoint, segment);
    }
    
    /// <summary>
    /// Get information about all segments in a list
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    internal async Task<RootSegment> GetAllSegmentsAsync(string list_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.segments, SubTargetType.not_applicable,
                                              list_id);

      string content;
      using (var client = new HttpClient())
      {
        Authenticate.ClientAuthentication(client);

        content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
      }

      return JsonConvert.DeserializeObject<RootSegment>(content);
    }

    /// <summary>
    /// Get information about a specific segment
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="segment_id">Unique id for the segment</param>
    /// </summary>
    internal async Task<RootSegment> GetSegmentInfoAsync(string list_id, string segment_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.segments, SubTargetType.not_applicable,
                                              list_id, segment_id);

      string content;
      using (var client = new HttpClient())
      {
        Authenticate.ClientAuthentication(client);

        content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
      }

      return JsonConvert.DeserializeObject<RootSegment>(content);
    }

    /// <summary>
    /// Delete a segment
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="segment_id">The segment id to get</param>
    /// </summary>
    internal async Task<HttpResponseMessage> DeleteSegmentAsync(string list_id, string segment_id)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.lists, SubTargetType.segments, SubTargetType.not_applicable,
                                              list_id, segment_id);

      HttpResponseMessage result;
      using (var client = new HttpClient())
      {
        try
        {
          Authenticate.ClientAuthentication(client);

          result = await client.DeleteAsync(endpoint).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
          throw ex;
        }
      }
      return result;
    }
  }
}