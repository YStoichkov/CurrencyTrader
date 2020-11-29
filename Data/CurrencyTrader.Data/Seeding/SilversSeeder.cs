namespace CurrencyTrader.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CurrencyTrader.Data.Models;

    public class SilversSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Silvers.Any())
            {
                return;
            }
            else
            {
                var silvers = new List<string>
                {
                    "1 килограм Valcambi сребърно кюлче", "1 килограм австралийски лунар Мишка 2020", "30 грама сребърна китайска панда от 2016",
                    "1 унция австралийски лунар Мишка 2020", "1 унция сребърен австралийски лунар Прасе 2019", "1 килограм сребърен австралийски лунар прасе 2019",
                    "1 килограм австралийска кукабура", "1 унция сребърна австрийска Филхармония", "1 унция сребърна монета канадски кленов лист", "1 унция сребърна монета австралийско кенгуру",
                    "1 унция сребърен американски орел", "1 унция сребърна австралийска кукабура", "1 унция сребърна монета австралийска кукабура 2016",
                    "1 унция сребърна австралийска коала", "1 унция сребърна китайска панда",
                };
                var buyForPrices = new List<int>
                {
                    1193, 1252, 39, 41, 41, 1252, 1252, 41, 41, 41, 41, 41, 41, 41, 41,
                };
                var sellForPrices = new List<int>
                {
                    1650, 2152, 95, 156, 156, 2152, 2152, 55, 71, 56, 76, 80, 80, 78, 134,
                };
                int count = 0;
                foreach (var silver in silvers)
                {
                    await dbContext.Silvers.AddAsync(new Silver
                    {
                        Name = silver,
                        BuyForPrice = buyForPrices[count],
                        SellForPrice = sellForPrices[count],
                    });
                    count++;
                }
            }
        }
    }
}
