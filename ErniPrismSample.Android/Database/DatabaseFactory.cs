using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ErniPrismSample.Repository;
using SQLite;

namespace ErniPrismSample.Android.Database
{
    public class DatabaseFactory : IDatabaseFactory
    {
        public string GetDatabasePath(string databaseName)
        {
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, "..", databaseName);
        }
    }
}