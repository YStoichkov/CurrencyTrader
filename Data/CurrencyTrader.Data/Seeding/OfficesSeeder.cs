namespace CurrencyTrader.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CurrencyTrader.Data.Models;

    public class OfficesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Offices.Any())
            {
                return;
            }
            else
            {
                var currencies = new List<string> { "Plovdiv", "Varna", "Sofia" };
                var address = new List<string> { "bul. Ivan Vazov 50", "pl. Nezavisimost", "bul. Aleksandar Stamboliyski 25" };
                var phone = new List<string> { "0897 305 533", "0892 352 333", "0899 111 222" };
                var email = new List<string> { "plovdiv_wizzard@currency.bg", "varna_wizzard@currency.bg", "sofia_wizzard@currency.bg" };
                var description = new List<string> { "Test office Plodvid", "Test office Varna", "Test office Sofia" };
                int count = 0;
                foreach (var currency in currencies)
                {
                    await dbContext.Offices.AddAsync(new Office
                    {
                        City = currency,
                        Address = address[count],
                        Phone = phone[count],
                        Email = email[count],
                        Description = description[count],
                    });
                    count++;
                }
            }
        }
    }
}
