using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMaster.Models;

namespace StockMaster.Data
{
    public class DataBaseQueries
    {
        private readonly NyDatabaseContext _context;
        public DataBaseQueries(NyDatabaseContext context) {
            _context = context;
        }
        public bool IsNameTaken(string name) => _context.Users.Any(t => t.UserName == name); // Any() -> повертає true якщо щось знайшло інакше false
        public void AddUser(User user) {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public User? IsUserExist(User user) => _context.Users.FirstOrDefault(u => u.UserName == user.UserName && u.UserPassword == user.UserPassword);
        public void DeleteUser(User user) {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
        public Stock AddStock(Stock stock) {
            _context.Stocks.Add(stock);
            _context.SaveChanges();
            return stock;
        }
    }
}
