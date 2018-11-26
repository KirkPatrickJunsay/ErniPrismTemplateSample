using System;
using System.Collections.Generic;
using System.Text;

namespace ErniPrismSample.Repository
{
    public interface IDataProvider
    {
        int SaveItem<T>(T item) where T : class, new();
        IEnumerable<T> GetItemList<T>() where T : class, new();
    }
}
