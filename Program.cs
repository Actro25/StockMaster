using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StockMaster.Classes;
using StockMaster.Classes.CardCreation;
using StockMaster.Data;
using StockMaster.Forms.Quick;
using StockMaster.Forms.ShowData;
using StockMaster.Services;
using System;
using System.IO;
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

            var host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddDbContext<NyDatabaseContext>(options =>
                {
                    string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBase", "database.db");
                    if (!Directory.Exists(Path.GetDirectoryName(dbPath)))
                        Directory.CreateDirectory(Path.GetDirectoryName(dbPath));
                    options.UseSqlite($"Data Source={dbPath}");
                });
                services.AddScoped<DataBaseQueries>();
                services.AddSingleton<ValidationService>();
                services.AddSingleton<CardCreationInStocks>(); 
                services.AddSingleton<UserSession>();
                services.AddSingleton<StockStorage>();
                services.AddSingleton<ShowFunctionDataInStockClass>();
                services.AddSingleton<ShowPhysicDataInStockClass>();
                services.AddSingleton<FunctionalDataStorage>();
                services.AddSingleton<PhysicDataStorage>();

                services.AddTransient<StockSettingsForm>();
                services.AddTransient<UpdateFunctionalStockData>();
                services.AddTransient<UpdatePhysicStockData>();
                services.AddTransient<AddFunctionalDataInStock>();
                services.AddTransient<AddPhysicDataInStock>();
                services.AddTransient<AddNewStockForm>();
                services.AddTransient<StockDataFunctionStockShowForm>();
                services.AddTransient<StockDataPhysicStockShowForm>();
                services.AddTransient<Form1>();
            }).Build();

            using var scope = host.Services.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<Form1>();

            Application.Run(form);
        }
    }
}
