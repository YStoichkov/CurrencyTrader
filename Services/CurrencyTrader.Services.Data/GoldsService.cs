namespace CurrencyTrader.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using CurrencyTrader.Data.Common.Repositories;
    using CurrencyTrader.Data.Models;
    using CurrencyTrader.Services.Mapping;

    public class GoldsService : IGoldsService
    {
        private readonly IDeletableEntityRepository<Gold> goldsRepository;

        public GoldsService(IDeletableEntityRepository<Gold> goldsRepository)
        {
            this.goldsRepository = goldsRepository;
        }

        public IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12)
        {
            var golds = this.goldsRepository.AllAsNoTracking()
                 .OrderByDescending(x => x.Id)
                 .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                 .To<T>()
                 .ToList();
            return golds;
        }

        // public IEnumerable<T> GetAll<T>(int? count = null)
        // {
        //    IQueryable<Gold> query = this.goldsRepository.All().OrderBy(x => x.Name);
        //    if (count.HasValue)
        //    {
        //        query = query.Take(count.Value);
        //    }

        // return query.To<T>().ToList();
        // }
        public T GetByName<T>(string name)
        {
            var currency = this.goldsRepository.All()
                .Where(x => x.Name.Replace(" ", "-") == name.Replace(" ", "-"))
                .To<T>().FirstOrDefault();
            return currency;
        }

        public int GetCount()
        {
            return this.goldsRepository.All().Count();
        }
    }
}
