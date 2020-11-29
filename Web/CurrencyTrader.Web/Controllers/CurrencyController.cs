namespace CurrencyTrader.Web.Controllers
{
    using CurrencyTrader.Services.Data;
    using CurrencyTrader.Web.ViewModels.Currency;
    using Microsoft.AspNetCore.Mvc;

    public class CurrencyController : Controller
    {
        private readonly ICurrenciesService currencyService;

        public CurrencyController(ICurrenciesService currencyService)
        {
            this.currencyService = currencyService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            var currencies = this.currencyService.GetAll<IndexCurrencyViewModel>();
            viewModel.Currencies = currencies;
            return this.View(viewModel);
        }

        public IActionResult Detailed(string name)
        {
            var viewModel =
                this.currencyService.GetByName<IndexCurrencyViewModel>(name);
            return this.View(viewModel);
        }
    }
}
