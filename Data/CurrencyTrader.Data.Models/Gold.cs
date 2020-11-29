namespace CurrencyTrader.Data.Models
{
    using CurrencyTrader.Data.Common.Models;

    public class Gold : BaseDeletableModel<int>
    {
        public string ImageUrl { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int BuyForPrice { get; set; }

        public int SellForPrice { get; set; }
    }
}
