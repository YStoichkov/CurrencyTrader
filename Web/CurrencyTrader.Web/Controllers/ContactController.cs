namespace CurrencyTrader.Web.Controllers
{
    using System.Threading.Tasks;

    using CurrencyTrader.Services.Messaging;
    using CurrencyTrader.Web.ViewModels.Contact;
    using Microsoft.AspNetCore.Mvc;

    public class ContactController : Controller
    {
        private readonly IEmailSender emailSender;

        public ContactController(IEmailSender emailSender)
        {
            this.emailSender = emailSender;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail(ContactViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.emailSender.SendEmailAsync(viewModel.Email, viewModel.Name, "ystoichkov@gmail.com", viewModel.Subject, viewModel.Message);

            return this.Redirect("Success");
        }

        public IActionResult Success()
        {
            return this.View();
        }
    }
}
