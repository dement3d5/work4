using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinSqlite.Models
{
    public class DboContext : DbContext
    {
        public DbSet<Item> Item { get; set; }
        public DbSet<TypeItem> TypeItem { get; set; }

        private string _databasePath;

        public DboContext(string databasePath)
        {
            _databasePath = databasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
