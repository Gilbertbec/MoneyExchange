namespace MoneyExchange.DAL
{
    using MoneyExchange.Data.Entities;
    using System.Collections.Generic;

    public interface IWriter<T> where T : R
    {
        void WriteToFile(ICollection<T> collection, string filePath);
    }
}
