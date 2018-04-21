﻿using System;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;

namespace MailChimp.Api.Net.Services.Reports
{
  // ==================================================================
  // AUTHOR      : Shahriar Hossain
  // PURPOSE     : Get list member activity for a specific campaign. 
  // ==================================================================

  internal class MCReportsEmailActivity
  {
    /// <summary>
    /// Return list member activity for a specific campaign
    /// <param name="campaignId">Unique id for the campaign</param>
    /// </summary>
    internal async Task<EmailActivity> GetEmailActivityAsync(string campaignId)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.email_activity,
                                              SubTargetType.not_applicable, campaignId);

      return await BaseOperation.GetAsync<EmailActivity>(endpoint);
    }


    /// <summary>
    /// Return list member activity for a specific campaign
    /// <param name="campaignId">Unique id for the campaign</param>
    /// <param name="offset">The number of records from a collection to skip. Iterating over large collections with this parameter can be slow</param>
    /// <param name="count">The number of records to return.</param>
    /// </summary>
    internal async Task<EmailActivity> GetEmailActivityAsync(string campaignId, int offset = 0, int count = 10)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.email_activity,
                                              SubTargetType.not_applicable, campaignId);

      endpoint = String.Format("{0}?offset={1}&count={2}", endpoint, offset, count);

      return await BaseOperation.GetAsync<EmailActivity>(endpoint);
    }


    /// <summary>
    /// Return list member activity for a specific campaign
    /// <param name="campaignId">Unique id for the campaign</param>
    /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
    /// </summary>
    internal async Task<EmailActivity> GetSubscriberEmailActivityAsync(string campaignId, string subscriber_hash)
    {
      string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.email_activity,
                                              SubTargetType.not_applicable, campaignId, subscriber_hash);

      return await BaseOperation.GetAsync<EmailActivity>(endpoint);
    }
  }
}