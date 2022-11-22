using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinSqlite.Models;

namespace XamarinSqlite.Services
{
    public class DBInstance
    {
        private static DboContext instance;

        private const string FILENAME = "database.db";

        public static DboContext GetInstance()
        {
            if (instance == null)
            {
                string path = DependencyService.Get<IPath>().GetDbPath(FILENAME);
                instance = new DboContext(path);
                instance.Database.EnsureCreated();
            }
            return instance;
        }
    }
}
