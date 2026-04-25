using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMaster.Services
{
    static public class SearchPanelDataService
    {
        static public Dictionary<int, List<Panel>> SearchById(Dictionary<int,List<Panel>> data, int id) {
            var temp = data.Where(d => (int.TryParse(d.Value[0].Controls["idLabel"].Text, out int res) ? res : 0) == id).ToDictionary(p => p.Key, p => p.Value);
            return temp;
        }
        static public void SearchByName(Dictionary<int, List<Panel>> data, string name) { }
        static public void SearchByQuantity(Dictionary<int, List<Panel>> data, int quantity) {
            var temp = data.Where(d => (int.TryParse(d.Value[2].Controls["quantityLabel"].Text, out int res) ? res : 0) == quantity);
        }
        static public void SearchByDate(Dictionary<int, List<Panel>> data, DateTime date) {
            var temp = data.Where(d => (DateTime.TryParse(d.Value[3].Controls["dateLabel"].Text, out DateTime res) ? res : DateTime.MinValue) == date);
        }
        static public void SearchByPrice(Dictionary<int, List<Panel>> data, decimal price) {
            var temp = data.Where(d => (decimal.TryParse(d.Value[4].Controls["priceLabel"].Text, out decimal res) ? res : 0.0M) == price);
        }
    }
}
