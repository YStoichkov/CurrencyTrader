namespace CurrencyTrader.Web.ViewModels.Currency
{
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public IEnumerable<IndexCurrencyViewModel> Currencies { get; set; }
    }
}
