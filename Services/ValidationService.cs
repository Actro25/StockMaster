using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StockMaster.Services
{
    public class ValidationService
    {
        public bool IsValidPassword(string password) => Regex.IsMatch(password, @"^\S+$");
        public bool IsValidUserName(string user) => Regex.IsMatch(user, @"^\S+$");
    }
}
