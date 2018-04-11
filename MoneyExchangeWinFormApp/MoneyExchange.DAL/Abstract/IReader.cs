namespace MoneyExchange.DAL
{
    using MoneyExchange.Data.Entities;
    using System.Collections.Generic;

    public interface IReader<T> where T : R
    {
        ICollection<T> ReadFromFile(string filePath);
    }
}
