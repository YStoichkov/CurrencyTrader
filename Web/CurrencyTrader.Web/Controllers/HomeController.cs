namespace CurrencyTrader.Web.Controllers
{
    using System.Diagnostics;

    using CurrencyTrader.Web.ViewModels;
    using CurrencyTrader.Web.ViewModels.Currency;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        public IActionResult Currency()
        {
            return this.View("~/Views/Currency/Currency.cshtml", new IndexCurrencyViewModel());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // TODO...error handling view
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
