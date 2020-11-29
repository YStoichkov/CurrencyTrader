namespace CurrencyTrader.Web.ViewModels.Gold
{
    using System.Collections.Generic;

    public class IndexViewModel : PagingViewModel
    {
        public IEnumerable<IndexGoldViewModel> Golds { get; set; }
    }
}
