﻿using System.Collections.Generic;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Templates
{
  public class RootTemplate
  {
    public List<Template> templates { get; set; }
    public List<Link2> _links { get; set; }
    public int total_items { get; set; }
  }
}