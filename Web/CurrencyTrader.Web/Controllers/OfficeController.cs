namespace CurrencyTrader.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class OfficeController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Detailed()
        {
            return this.View();
        }
    }
}
