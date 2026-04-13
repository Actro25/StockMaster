using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using StockMaster.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace StockMaster
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder().ConfigureServices((context, services) => {
                services.AddDbContext<NyDatabaseContext>(options => {
                    string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBase", "database.db");
                    if (!Directory.Exists(Path.GetDirectoryName(dbPath))) 
                        Directory.CreateDirectory(Path.GetDirectoryName(dbPath));
                    options.UseSqlite($"Data Source={dbPath}");
                });
                services.AddTransient<Form1>();
            }).Build();
            using var scope = host.Services.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<Form1>();

            Application.Run(form);
        }
    }
}
