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
            CurrentUser = user; 
            OnLoginSuccess?.Invoke();
        }
        public void Logout() { 
            CurrentUser = null;
            OnLogoutSuccess?.Invoke();
        }
        public bool IsLogined() => CurrentUser != null;
    }
}
