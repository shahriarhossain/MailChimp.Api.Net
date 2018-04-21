namespace MailChimp.Api.Net.Domain.Campaigns
{
  public class Condition
  {
    public string field { get; set; }
    public string op { get; set; }
    public string value { get; set; }  //Should be integer but fails unless it is a string?
  }
}