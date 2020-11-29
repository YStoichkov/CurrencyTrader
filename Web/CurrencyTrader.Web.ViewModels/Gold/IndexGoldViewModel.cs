namespace CurrencyTrader.Web.ViewModels.Gold
{
    using CurrencyTrader.Data.Models;
    using CurrencyTrader.Services.Mapping;

    public class IndexGoldViewModel : IMapFrom<Gold>
    {
        public string ImageUrl { get; set; }

        public string Name { get; set; }

        public int SellForPrice { get; set; }

        public int BuyForPrice { get; set; }

        public string Description { get; set; }

        public string Url => $"/Gold/{this.Name.Replace(' ', '-')}";
    }
}
