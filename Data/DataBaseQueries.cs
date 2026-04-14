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
        public bool IsUserExist(User user) {

            return _context.Users.Any(u => u.UserName == user.UserName && u.UserPassword == user.UserPassword);
            
        }
    }
}
