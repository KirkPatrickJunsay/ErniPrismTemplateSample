using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErniPrismSample.Repository
{
    public interface IDatabaseFactory
    {
        string GetDatabasePath(string databaseName);
    }
}
