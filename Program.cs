using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using StockMaster.Classes;
using StockMaster.Classes.CardCreation;
using StockMaster.Data;
using StockMaster.Services;
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

            /*
              Як це працює?
             */

            var host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                /*
                 Тут передаємо в функцію ConfigureServices люмда вираз з параметрами. 
                По логіці передаємо services, це фігнюшка в якій ми реєструємо наші клас в яких хочемо за нашим бажанням базово отримувати dbcontext
                 */
                services.AddDbContext<NyDatabaseContext>(options =>
                {
                    /*
                        Ось тут ми просто створюємо наш context, але як зробити по патерну DRY щоб неповторювалося в NyDatabaseContext я хз.
                     */
                    string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBase", "database.db");
                    if (!Directory.Exists(Path.GetDirectoryName(dbPath)))
                        Directory.CreateDirectory(Path.GetDirectoryName(dbPath));
                    options.UseSqlite($"Data Source={dbPath}");
                });
                services.AddScoped<DataBaseQueries>(); // Реєструємо наш клас для отримання context
                services.AddSingleton<ValidationService>(); // Ще один клас для валідації
                services.AddSingleton<CardCreationInStocks>(); // Клас для виведення карточок
                services.AddSingleton<UserSession>(); // Клас для зберігання сесії

                services.AddTransient<AddNewStockForm>();
                services.AddTransient<Form1>(); //Незнаю
            }).Build();

            using var scope = host.Services.CreateScope(); //Я предполагаю тут створюємо продовжуваність життя нашого context
            var form = scope.ServiceProvider.GetRequiredService<Form1>();

            Application.Run(form);
        }
    }
}
