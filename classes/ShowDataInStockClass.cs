using Microsoft.Extensions.DependencyInjection;
using StockMaster.Data;
using StockMaster.Models;
using StockMaster.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMaster.Classes
{
    public class ShowDataInStockClass
    {
        private IServiceScopeFactory _scopeFactory;
        private IServiceProvider _serviceProvider;
        private StockStorage _mainStock;
        private FunctionalDataStorage _currentDataSelected;

        private Dictionary<int, List<Panel>> _rowGroups = new Dictionary<int, List<Panel>>();
        private int _lastSelectedId = -1;

        private Panel _idPanel;
        private Panel _namePanel;
        private Panel _quantityPanel;
        private Panel _dataPanel;
        private Panel _pricePanel;
        public ShowDataInStockClass(IServiceScopeFactory scopeFactory, IServiceProvider serviceProvider, StockStorage mainStock, FunctionalDataStorage currentDataSelected)
        {
            _scopeFactory = scopeFactory;
            _serviceProvider = serviceProvider;
            _mainStock = mainStock;
            _currentDataSelected = currentDataSelected;
        }
        public void Init(Panel idp, Panel namep, Panel quantityp, Panel datap, Panel pricep ) {
            _idPanel = idp;
            _namePanel = namep;
            _quantityPanel = quantityp;
            _dataPanel = datap;
            _pricePanel = pricep;
        }
        public async Task UpdateDataTableWithNewData() {
            ClearRowsWithdata();
            using (var scopedQueries = _scopeFactory.CreateScope()) {
                var queries = scopedQueries.ServiceProvider.GetRequiredService<DataBaseQueries>();
                var temp = await queries.GetAllFunctionDataStocksById(_mainStock.Current.Id);
                UpdateEveryRow(temp);
            }
        }
        public void RefreshDataTable() {
            _idPanel.SuspendLayout();
            _namePanel.SuspendLayout();
            _quantityPanel.SuspendLayout();
            _dataPanel.SuspendLayout();
            _pricePanel.SuspendLayout();
            try
            {
                foreach (var item in _rowGroups)
                {
                    _idPanel.Controls.Add(item.Value[0]);
                    _namePanel.Controls.Add(item.Value[1]);
                    _quantityPanel.Controls.Add(item.Value[2]);
                    _dataPanel.Controls.Add(item.Value[3]);
                    _pricePanel.Controls.Add(item.Value[4]);
                }
            }
            finally {
                _idPanel.ResumeLayout();
                _namePanel.ResumeLayout();
                _quantityPanel.ResumeLayout();
                _dataPanel.ResumeLayout();
                _pricePanel.ResumeLayout();
            }
        }
        public bool DeleteCurrentDataRow() {
            if (_lastSelectedId == -1)
                return false;
            using (var scope = _scopeFactory.CreateScope())
            {
                var queries = scope.ServiceProvider.GetRequiredService<DataBaseQueries>();
                queries.DeleteFunctionDataById(_lastSelectedId);
            }
            return true;
        }
        public bool GetCurrentDataRow() {
            if (_lastSelectedId == -1)
                return false;
            using (var scope = _scopeFactory.CreateScope())
            {
                var queries = scope.ServiceProvider.GetRequiredService<DataBaseQueries>();
                _currentDataSelected.Current = queries.GetFunctionDataStockById(_lastSelectedId);
            }
            return true;
        }
        private void ClearRows() {
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
        private void ClearRowsWithdata() {
            ClearRows();

            _rowGroups.Clear();
            _lastSelectedId = -1;
        }
        private void UpdateEveryRow(List<FunctionStockData> data) {
            foreach (var item in data) {
                Label lbId = new Label { Name = "idLabel" , Text = item.Id.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter };
                Label lbName = new Label { Name = "nameLabel", Text = item.NameOfGood, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
                Label lbQuan = new Label { Name = "quantityLabel", Text = item.Quantity.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
                Label lbData = new Label { Name = "dateLabel", Text = item.DateOfArrival.ToString("dd.MM.yyyy HH:mm"), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
                Label lbPrice = new Label { Name = "priceLabel", Text = item.Price.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };

                Panel idPanHolder = new Panel{
                    Margin = new Padding(0),
                    Size = new Size(_idPanel.Size.Width, 25),
                    AutoScroll = false,
                    Tag = item.Id
                };
                idPanHolder.Click += (s, e) => SelectRowGroup((int)idPanHolder.Tag);
                lbId.Click += (s, e) => SelectRowGroup((int)idPanHolder.Tag);
                idPanHolder.Controls.Add(lbId);

                Panel namePanHolder = new Panel {
                    Margin = new Padding(0),
                    Size = new Size(_namePanel.Size.Width, 25),
                    AutoScroll = false,
                    Padding = new Padding(10, 0, 0, 0),
                    Tag = item.Id
                };
                namePanHolder.Click += (s, e) => SelectRowGroup((int)namePanHolder.Tag);
                lbName.Click += (s, e) => SelectRowGroup((int)namePanHolder.Tag);
                namePanHolder.Controls.Add(lbName);

                Panel quanPanHolder = new Panel {
                    Margin = new Padding(0),
                    Size = new Size(_quantityPanel.Size.Width, 25),
                    AutoScroll = false,
                    Padding = new Padding(10, 0, 0, 0),
                    Tag = item.Id
                };
                quanPanHolder.Click += (s, e) => SelectRowGroup((int)quanPanHolder.Tag);
                lbQuan.Click += (s, e) => SelectRowGroup((int)quanPanHolder.Tag);
                quanPanHolder.Controls.Add(lbQuan);

                Panel dataPanHolder = new Panel {
                    Margin = new Padding(0),
                    Size = new Size(_dataPanel.Size.Width, 25),
                    AutoScroll = false,
                    Padding = new Padding(10, 0, 0, 0),
                    Tag = item.Id
                };
                dataPanHolder.Click += (s, e) => SelectRowGroup((int)dataPanHolder.Tag);
                lbData.Click += (s, e) => SelectRowGroup((int)dataPanHolder.Tag);
                dataPanHolder.Controls.Add(lbData);

                Panel pricePanHolder = new Panel {
                    Margin = new Padding(0),
                    Size = new Size(_pricePanel.Size.Width, 25),
                    AutoScroll = false,
                    Padding = new Padding(10, 0, 0, 0),
                    Tag = item.Id
                };
                pricePanHolder.Click += (s, e) => SelectRowGroup((int)pricePanHolder.Tag);
                lbPrice.Click += (s, e) => SelectRowGroup((int)pricePanHolder.Tag);
                pricePanHolder.Controls.Add(lbPrice);

                

                _rowGroups.Add(item.Id, new List<Panel> { idPanHolder, namePanHolder, quanPanHolder, dataPanHolder, pricePanHolder });

                _idPanel.Controls.Add(idPanHolder);
                _namePanel.Controls.Add(namePanHolder);
                _quantityPanel.Controls.Add(quanPanHolder);
                _dataPanel.Controls.Add(dataPanHolder);
                _pricePanel.Controls.Add(pricePanHolder);
            }
        }
        private void SelectRowGroup(int Id) {
            // Тут ми вибираємо весь рядок для показу що ми щось вибрали з таблиці

            //Тут призупиняємо вимальовування щоб ми взяли і все одночасно зробили (щоб для користувача все сталося миттєво, а не по кусочкам вимальовувалося)
            _idPanel.SuspendLayout();
            _namePanel.SuspendLayout();
            _quantityPanel.SuspendLayout();
            _dataPanel.SuspendLayout();
            _pricePanel.SuspendLayout();

            try
            {
                // Змінюємо колір у минулих панелях
                if (_lastSelectedId != -1 && _rowGroups.TryGetValue(_lastSelectedId, out List<Panel> panelsOld))
                {
                    foreach (var item in panelsOld)
                        item.BackColor = Color.Transparent;
                }
                // Змінюємо колір у нових панелях
                if (_rowGroups.TryGetValue(Id, out List<Panel> panelsNew))
                {
                    foreach (var item in panelsNew)
                        item.BackColor = Color.LightBlue;

                    _lastSelectedId = Id;
                }
            }
            finally
            {
                // Включаємо промалювання панелей
                _idPanel.ResumeLayout();
                _namePanel.ResumeLayout();
                _quantityPanel.ResumeLayout();
                _dataPanel.ResumeLayout();
                _pricePanel.ResumeLayout();
            }
        }
        public void SortDataByIdColumn(bool isFromHigher) {
            _rowGroups = SortPanelDataService.SortById(_rowGroups, isFromHigher);
            RefreshDataTable();
        }
        public void SortDataByNameColumn(bool isFromHigher) {
            _rowGroups = SortPanelDataService.SortByName(_rowGroups, isFromHigher);
            RefreshDataTable();
        }
        public void SortDataByQuantityColumn(bool isFromHigher) {
            _rowGroups = SortPanelDataService.SortByQuantity(_rowGroups, isFromHigher);
            RefreshDataTable();
        }
        public void SortDataByDateColumn(bool isFromHigher) {
            _rowGroups = SortPanelDataService.SortByDate(_rowGroups, isFromHigher);
            RefreshDataTable();
        }
        public void SortDataByPriceColumn(bool isFromHigher) {
            _rowGroups = SortPanelDataService.SortByPrice(_rowGroups, isFromHigher);
            RefreshDataTable();
        }
    }
}
