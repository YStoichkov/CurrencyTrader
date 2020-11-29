namespace CurrencyTrader.Data.Models
{
    using CurrencyTrader.Data.Common.Models;
    using CurrencyTrader.Data.Models.Enums;

    public class Job : BaseDeletableModel<string>
    {
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public decimal? Salary { get; set; }

        public Category Category { get; set; }
    }
}
