namespace CurrencyTrader.Data.Models
{
    using CurrencyTrader.Data.Common.Models;

    public class Office : BaseDeletableModel<int>
    {
        public string City { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }
    }
}
