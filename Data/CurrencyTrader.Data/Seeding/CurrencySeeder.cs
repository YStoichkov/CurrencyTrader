namespace CurrencyTrader.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CurrencyTrader.Data.Models;

    public class CurrencySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Currencies.Any())
            {
                return;
            }
            else
            {
                var currencies = new List<string>
                {
                    "Евро", "Британска лира", "Щатски долар", "Швейцарски франк", "Румънска лея", "Унгарски форинт", "Турска лира",
                    "Руска рубла", "Аржентинско песо", "Канадски долар", "Австралийски долар", "Китайски юан", "Чешка крона", "Датска крона", "Сръбски динар",
                    "Шведска крона", "Бразилски реал", "Хърватска куна", "Израелски шекел", "Индийска рупия", "Японска йена", "Македонски денар", "Мексиканско песо", "Полска злота",
                };
                var codes = new List<string>
                {
                    "EUR", "GBP", "USD", "CHF", "RON", "HUF", "TRL", "RUB", "ARS", "CAD", "AUD", "CNY", "CZK", "DKK", "RSD", "SEK", "BRL", "HRK", "ILS", "INR", "JPY", "MKD", "MXN", "PLN",
                };
                int count = 0;
                foreach (var currency in currencies)
                {
                    await dbContext.Currencies.AddAsync(new Currency
                    {
                        CurrencyCode = codes[count],
                        CurrencyName = currency,
                        Description = currency,
                    });
                    count++;
                }
            }
        }
    }
}
