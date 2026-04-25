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
        public bool IsValidName(string user) => Regex.IsMatch(user, @"^[a-zA-Z0-9а-яА-ЯіїєґІЇЄҐ_]+$");
        public bool IsValidNameGood(string name) => Regex.IsMatch(name, @"^[a-zA-Z0-9а-яА-ЯіїєґІЇЄҐ|\/\*\(\) ]+$");
        public bool IsOnlyIntegers(string text) => Regex.IsMatch(text, @"^[0-9]+$");
        public bool IsFloatPointInteger(string text) => Regex.IsMatch(text, @"^[0-9]+([.,][0-9]+)?$");
        public bool IsDate(string date) => DateTime.TryParseExact(date, "dd.MM.yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out _);
    }
}
