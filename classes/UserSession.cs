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

        public event Action? OnLoginSuccess;
        public event Action? OnLogoutSuccess;
        public void Login(User user) { 
            CurrentUser = user;  // Записуємо user в сесію
            OnLoginSuccess?.Invoke(); // Запускаємо функції під час входу в акаунт
        }
        public void Logout() { 
            CurrentUser = null;  // Видаляємо user з сесії
            OnLogoutSuccess?.Invoke();// Запускаємо функції під час виходу з акаунту
        }
        public bool IsLogined() => CurrentUser != null; // Перевіряємо чи user залогінений
    }
}
