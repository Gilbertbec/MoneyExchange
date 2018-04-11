namespace MoneyExchange.DAL
{
    using MoneyExchange.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;

    public class TextFileReader<T> : IReader<T> where T : R
    {
        public ICollection<T> ReadFromFile(string filePath)
        {
            ICollection<T> list = new List<T>();

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Type typeOfT = typeof(T);
                        Assembly assembly = Assembly.GetAssembly(typeOfT);

                        object[] parameters = new object[1];
                        parameters[0] = line;
                        object result = assembly.CreateInstance("MoneyExchange.Data.Entities.R", true, System.Reflection.BindingFlags.Default, null, parameters, null, null);
                        T t = (T)result;
                        list.Add(t);
                    }
                }
            }
            return list;
        }
    }
}
