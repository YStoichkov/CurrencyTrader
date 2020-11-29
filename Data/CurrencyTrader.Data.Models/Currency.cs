namespace CurrencyTrader.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using CurrencyTrader.Data.Common.Models;

    public class Currency : BaseDeletableModel<int>
    {
        public string CurrencyImage { get; set; }

        [Required]
        [MaxLength(3)]
        public string CurrencyCode { get; set; }

        [Required]
        public string CurrencyName { get; set; }

        public int AvailableQuantity { get; set; }

        public decimal BuyForPrice { get; set; }

        public decimal SellForPrice { get; set; }

        public string Description { get; set; }
    }
}
