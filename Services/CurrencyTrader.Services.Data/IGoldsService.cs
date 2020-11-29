namespace CurrencyTrader.Services.Data
{
    using System.Collections.Generic;

    public interface IGoldsService
    {
        IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12);

        int GetCount();

        // T GetByName<T>(string name);
        T GetById<T>(int id);
    }
}
