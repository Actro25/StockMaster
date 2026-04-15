using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMaster.Models;

namespace StockMaster.Classes
{
    public class UserSession
    {
        public User? CurrentUser { get; private set; }

        public void Login(User user) => CurrentUser = user; // Записуємо user в сесію
        public void Logout() => CurrentUser = null; // Видаляємо user з сесії
        public bool IsLogined() => CurrentUser != null; // Перевіряємо чи user залогінений
    }
}
