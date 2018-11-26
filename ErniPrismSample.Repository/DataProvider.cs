using ErniPrismSample.Repository.DataTransferObject;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErniPrismSample.Repository
{
    public class DataProvider : IDataProvider
    {
        public SQLiteConnection Database { get; set; }

        public DataProvider(IDatabaseFactory databaseFactory)
        {
            var databasePath = databaseFactory.GetDatabasePath("UserDB.db");
            Database = new SQLiteConnection(databasePath);
            Database.CreateTable<UserDTO>();       
        }

        public IEnumerable<T> GetItemList<T>() where T : class, new()
        {
            return Database.Table<T>();
        }

        public int SaveItem<T>(T item) where T : class, new()
        {
            return Database.InsertOrReplace(item);
        }
    }
}
