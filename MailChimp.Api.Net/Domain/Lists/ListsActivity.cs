namespace MailChimp.Api.Net.Domain.Lists
{
    public class ListsActivity
    {
        public string day { get; set; }
        public int emails_sent { get; set; }
        public int unique_opens { get; set; }
        public int recipient_clicks { get; set; }
        public int hard_bounce { get; set; }
        public int soft_bounce { get; set; }
        public int subs { get; set; }
        public int unsubs { get; set; }
        public int other_adds { get; set; }
        public int other_removes { get; set; }
    }
}
