namespace CurrencyTrader.Web.Areas.Administration.Controllers
{
    using CurrencyTrader.Common;
    using CurrencyTrader.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
