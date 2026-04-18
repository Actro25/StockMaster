using Microsoft.Extensions.DependencyInjection;
using StockMaster.Data;
using StockMaster.Models;
using StockMaster.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMaster.Classes
{
    public class ShowDataInStockClass
    {
        List<FunctionStockData> _dataToShow = new List<FunctionStockData>();
        private IServiceScopeFactory _scopeFactory;
        private IServiceProvider _serviceProvider;
        private StockStorage _mainStock;

        Panel _idPanel;
        Panel _namePanel;
        Panel _quantityPanel;
        Panel _dataPanel;
        Panel _pricePanel;
        public ShowDataInStockClass(IServiceScopeFactory scopeFactory, IServiceProvider serviceProvider, StockStorage mainStock)
        {
            _scopeFactory = scopeFactory;
            _serviceProvider = serviceProvider;
            _mainStock = mainStock;
        }
        public void Init(Panel idp, Panel namep, Panel quantityp, Panel datap, Panel pricep ) {
            _idPanel = idp;
            _namePanel = namep;
            _quantityPanel = quantityp;
            _dataPanel = datap;
            _pricePanel = pricep;
        }
        public async Task UpdateDataTable() {
            ClearRows();
            using (var scopedQueries = _scopeFactory.CreateScope()) {
                var queries = scopedQueries.ServiceProvider.GetRequiredService<DataBaseQueries>();
                var temp = await queries.GetAllDataStocksById(_mainStock.Current.Id);
                UpdateEveryRow(temp);
            }
        }
        public void ClearRows() {
            _idPanel.Controls.Cast<Control>().ToList().ForEach(c => c.Dispose());
            _idPanel.Controls.Clear();

            _namePanel.Controls.Cast<Control>().ToList().ForEach(c => c.Dispose());
            _namePanel.Controls.Clear();

            _quantityPanel.Controls.Cast<Control>().ToList().ForEach(c => c.Dispose());
            _quantityPanel.Controls.Clear();

            _dataPanel.Controls.Cast<Control>().ToList().ForEach(c => c.Dispose());
            _dataPanel.Controls.Clear();

            _pricePanel.Controls.Cast<Control>().ToList().ForEach(c => c.Dispose());
            _pricePanel.Controls.Clear();
        }
        private void UpdateEveryRow(List<FunctionStockData> data) {
            foreach (var item in data) {
                Label lbId = new Label { Text = item.Id.ToString() };
                Label lbName = new Label { Text = item.NameOfGood };
                Label lbQuan = new Label { Text = item.Quantity.ToString() };
                Label lbData = new Label { Text = item.DateOfArrival.ToString() };
                Label lbPrice = new Label { Text = item.Price.ToString() };

                _idPanel.Controls.Add(lbId);
                _namePanel.Controls.Add(lbName);
                _quantityPanel.Controls.Add(lbQuan);
                _dataPanel.Controls.Add(lbData);
                _pricePanel.Controls.Add(lbPrice);
            }
        }
    }
}
