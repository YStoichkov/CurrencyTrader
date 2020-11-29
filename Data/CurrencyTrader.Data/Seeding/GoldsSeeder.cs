namespace CurrencyTrader.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CurrencyTrader.Data.Models;

    public class GoldsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Golds.Any())
            {
                return;
            }
            else
            {
                var golds = new List<string>
                {
                "1 унция златно Австралийско кенгуру", "100 грама златно кюлче РАМР Фортуна", "100 грама златно кюлче Valcambi",
                "100 куруша Турция", "1 австрийски дукат Франц Йосиф", "1 унция златна Виенска филхармония", "1 унция Австралийски лунар година на Прасето 2019",
                "1 унция Кругерранд Южна Африка", "1 грам златно кюлче Valcambi", "1 грам кюлче Рамр Фотруна", "1 унция златна монета лунар петел 2017",
                "1 унция златна монета лунар маймуна 2016", "20 франка Швейцария Вренели", "20 белгийски франка Леополд II", "20 лири Умберто I Италия",
                "20 лири Виктор Емануил II Италия", "20 франка Тунис", "10 Гулдена Вилхелм III Холдандия", "10 Гулдена Вилхелмина Холандия",
                "Суверен Едуард VII Великобритания", "Суверен Джордж V Великобритания", "Суверен Елизабет II Великобритания", "5 рубли Николай II Русия",
                "10 рубли Николай II Русия",
                };
                var sellForPrices = new List<int> { 3096, 9805, 9805, 685, 359, 3096, 4185, 3129, 134, 134, 3571, 3307, 606, 606, 596, 596, 606, 633, 633, 754, 754, 754, 492, 983 };
                var buyForPrices = new List<int> { 2938, 9332, 9332, 600, 333, 2938, 2908, 2938, 94, 94, 2908, 2908, 554, 559, 554, 554, 543, 566, 566, 681, 681, 681, 364, 728 };

                int count = 0;
                foreach (var gold in golds)
                {
                    await dbContext.Golds.AddAsync(new Gold
                    {
                        Name = gold,
                        SellForPrice = sellForPrices[count],
                        BuyForPrice = buyForPrices[count],
                    });
                    count++;
                }
            }
        }
    }
}
