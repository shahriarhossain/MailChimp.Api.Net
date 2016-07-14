namespace MailChimp.Api.Net.Domain.Campaigns
{
    public class Recipients
    {
        public string list_id { get; set; }
        public string segment_text { get; set; }
        public SegmentOpts segment_opts { get; set; }
    }
}
