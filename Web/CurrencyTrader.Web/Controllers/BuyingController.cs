namespace CurrencyTrader.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class BuyingController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
