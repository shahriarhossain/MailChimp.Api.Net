﻿using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Lists
{
  public class RootNote
  {
    public List<Note> notes { get; set; }
    public string email_id { get; set; }
    public string list_id { get; set; }
    public List<Link2> _links { get; set; }
    public int total_items { get; set; }
  }
}