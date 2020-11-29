namespace CurrencyTrader.Services.Data
{
    using System.Collections.Generic;

    public interface ICurrenciesService
    {
        IEnumerable<T> GetAll<T>(int? count = null);

        T GetByName<T>(string name);
    }
}
