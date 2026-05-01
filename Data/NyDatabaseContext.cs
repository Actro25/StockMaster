using Microsoft.EntityFrameworkCore;
using StockMaster.Models;
using System;
using System.IO;

namespace StockMaster.Data
{
    public class NyDatabaseContext : DbContext
    {
        public NyDatabaseContext() { }
        public NyDatabaseContext(DbContextOptions<NyDatabaseContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<FunctionStockData> FunctionStockData { get; set; }
        public DbSet<PhysicStockData> PhysicStockData { get; set; }
        public void InitializeDatabase() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                return;

            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBase", "database.db");
            if (!Directory.Exists(Path.GetDirectoryName(dbPath))) 
                Directory.CreateDirectory(Path.GetDirectoryName(dbPath));
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}
