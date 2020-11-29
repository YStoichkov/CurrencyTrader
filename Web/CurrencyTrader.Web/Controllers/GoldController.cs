namespace CurrencyTrader.Web.Controllers
{
    using CurrencyTrader.Services.Data;
    using CurrencyTrader.Web.ViewModels.Gold;
    using Microsoft.AspNetCore.Mvc;

    public class GoldController : Controller
    {
        private readonly IGoldsService goldsService;

        public GoldController(IGoldsService goldsService)
        {
            this.goldsService = goldsService;
        }

        public IActionResult Index(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int ItemsPerPage = 12;
            var viewModel = new IndexViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                GoldsCount = this.goldsService.GetCount(),
                Golds = this.goldsService.GetAll<IndexGoldViewModel>(id, ItemsPerPage),
            };
            return this.View(viewModel);
        }

        public IActionResult Detailed(int id)
        {
            var viewModel =
                this.goldsService.GetById<IndexGoldViewModel>(id);
            return this.View(viewModel);
        }
    }
}
