namespace CurrencyTrader.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class CareerController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
