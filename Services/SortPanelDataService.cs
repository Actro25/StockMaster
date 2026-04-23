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
        static public Dictionary<int, List<Panel>> SortById(Dictionary<int, List<Panel>> data)
        {
            return data
                .OrderBy(d => {
                    string dataText = d.Value[0].Controls["idLabel"].Text ?? "";
                    if (int.TryParse(dataText, out int result))
                        return result;
                    return 0;
                })
                .ToDictionary(p => p.Key, p => p.Value);
        }
        static public Dictionary<int, List<Panel>> SortByName(Dictionary<int, List<Panel>> data)
        {
            return data
                .OrderBy(d => d.Value[1].Controls["nameLabel"].Text ?? "")
                .ToDictionary(p => p.Key, p => p.Value);
        }
        static public Dictionary<int, List<Panel>> SortByQuantity(Dictionary<int, List<Panel>> data)
        {
            return data
                .OrderBy(d => {
                    string dataText = d.Value[2].Controls["quantitylabel"].Text ?? "";
                    if (int.TryParse(dataText, out int result))
                        return result;
                    return 0;
                })
                .ToDictionary(p => p.Key, p => p.Value);
        }
        static public Dictionary<int, List<Panel>> SortByDate(Dictionary<int, List<Panel>> data)
        {
            return data
                .OrderBy(d => {
                    string dataText = d.Value[3].Controls["datelabel"].Text ?? "";
                    if (DateTime.TryParse(dataText, out DateTime result))
                        return result;
                    return DateTime.MinValue;
                })
                .ToDictionary(p => p.Key, p => p.Value); ;
        }
        static public Dictionary<int, List<Panel>> SortByPrice(Dictionary<int, List<Panel>> data)
        {
            return data
                .OrderBy(d => {
                    string dataText = d.Value[4].Controls["priceLabel"].Text ?? "";
                    if (decimal.TryParse(dataText, out decimal result))
                        return result;
                    return 0.0M;
                })
                .ToDictionary(p => p.Key, p => p.Value);
        }
    }
}
