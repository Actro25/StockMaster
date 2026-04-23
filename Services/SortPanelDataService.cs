using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StockMaster.Services
{
    static public class SortPanelDataService
    {
        static public Dictionary<int, List<Panel>> SortById(Dictionary<int, List<Panel>> data, bool isFromHigher = false)
        {
            var sorted = data.OrderBy(d => int.TryParse(d.Value[0].Controls["idLabel"].Text, out int res) ? res : 0);
            return (isFromHigher ? sorted.Reverse() : sorted).ToDictionary(p => p.Key, p => p.Value);
        }
        static public Dictionary<int, List<Panel>> SortByName(Dictionary<int, List<Panel>> data, bool isFromHigher = false)
        {
            var sorted = data.OrderBy(d => d.Value[1].Controls["nameLabel"].Text ?? "");
            return (isFromHigher ? sorted.Reverse() : sorted).ToDictionary(p => p.Key, p => p.Value);
        }
        static public Dictionary<int, List<Panel>> SortByQuantity(Dictionary<int, List<Panel>> data, bool isFromHigher = false)
        {
            var sorted = data.OrderBy(d => int.TryParse(d.Value[2].Controls["quantityLabel"].Text, out int res) ? res : 0);
            return (isFromHigher ? sorted.Reverse() : sorted).ToDictionary(p => p.Key, p => p.Value);
        }
        static public Dictionary<int, List<Panel>> SortByDate(Dictionary<int, List<Panel>> data, bool isFromHigher = false)
        {
            var sorted = data.OrderBy(d => DateTime.TryParse(d.Value[3].Controls["dateLabel"].Text, out DateTime res) ? res : DateTime.MinValue);
            return (isFromHigher ? sorted.Reverse() : sorted).ToDictionary(p => p.Key, p => p.Value);
        }
        static public Dictionary<int, List<Panel>> SortByPrice(Dictionary<int, List<Panel>> data, bool isFromHigher = false)
        {
            var sorted = data.OrderBy(d => decimal.TryParse(d.Value[4].Controls["priceLabel"].Text, out decimal res) ? res : 0.0M);
            return (isFromHigher ? sorted.Reverse() : sorted).ToDictionary(p => p.Key, p => p.Value);
        }
    }
}
