namespace CurrencyTrader.Data.Models
{
    using CurrencyTrader.Data.Common.Models;

    public class ContactForm : BaseDeletableModel<int>
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Question { get; set; }
    }
}
