namespace CurrencyTrader.Web.Controllers
{
    using CurrencyTrader.Services.Data;
    using CurrencyTrader.Web.ViewModels.Silver;
    using Microsoft.AspNetCore.Mvc;

    public class SilverController : Controller
    {
        private readonly ISilversService silversService;

        public SilverController(ISilversService silversService)
        {
            this.silversService = silversService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            var silvers = this.silversService.GetAll<IndexSilverViewModel>();
            viewModel.Silvers = silvers;
            return this.View(viewModel);
        }
    }
}
