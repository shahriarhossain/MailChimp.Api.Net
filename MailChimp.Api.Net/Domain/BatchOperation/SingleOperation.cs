namespace MailChimp.Api.Net.Domain.BatchOperation
{
    public class SingleOperation
    {
        public string method { get; set; }
        public string path{ get; set; }
        public string body { get; set; }
        public string operation_id { get; set; }
    }
}
