using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMaster.Models;
using System.IO;

namespace StockMaster.Data
{
    public class NyDatabaseContext : DbContext
    {
        public NyDatabaseContext(DbContextOptions<NyDatabaseContext> options) : base(options)
        {
        }

        /*
         Тут пхеном наші моделі для таблиць
         */
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                return;

            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBase", "database.db"); // Створюємо шлях до місця де буде БД
            if (!Directory.Exists(Path.GetDirectoryName(dbPath))) // Перевіряємо чи існує такий шлях
                Directory.CreateDirectory(Path.GetDirectoryName(dbPath)); // Створюємо такий шлях якщо його неіснувало
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}
