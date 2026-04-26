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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StockMaster.Classes
{
    public class ShowDataInStockClass
    {
        private IServiceScopeFactory _scopeFactory;
        private IServiceProvider _serviceProvider;
        private StockStorage _mainStock;
        private FunctionalDataStorage _currentDataSelected;
        private ValidationService _validation;

        private Dictionary<int, List<Panel>> _rowGroups = new Dictionary<int, List<Panel>>();
        private int _lastSelectedId = -1;

        private Panel _idPanel;
        private Panel _namePanel;
        private Panel _quantityPanel;
        private Panel _dataPanel;
        private Panel _pricePanel;
        public ShowDataInStockClass(IServiceScopeFactory scopeFactory, IServiceProvider serviceProvider, 
            StockStorage mainStock, FunctionalDataStorage currentDataSelected, ValidationService validation)
        {
            _scopeFactory = scopeFactory;
            _serviceProvider = serviceProvider;
            _mainStock = mainStock;
            _currentDataSelected = currentDataSelected;
            _validation = validation;
            
        }
        public void Init(Panel idp, Panel namep, Panel quantityp, Panel datap, Panel pricep ) {
            _idPanel = idp;
            _namePanel = namep;
            _quantityPanel = quantityp;
            _dataPanel = datap;
            _pricePanel = pricep;
        }
        public async Task UpdateDataTableWithNewData() {
            ClearRowCompletely();
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
        public bool ArrivedOrOverdueCurrentDataRow(bool isArrived, bool isOverdue) {
            if (_lastSelectedId == -1)
                return false;
            
            using (var scope = _scopeFactory.CreateScope())
            {
                FunctionStockData currentFunctionStockData;
                var queries = scope.ServiceProvider.GetRequiredService<DataBaseQueries>();
                currentFunctionStockData = queries.GetFunctionDataStockById(_lastSelectedId, _mainStock.Current.Id);

                currentFunctionStockData.isArrived = isArrived;
                currentFunctionStockData.isOverdue = isOverdue;

                queries.UpdateFunctionDataStock(currentFunctionStockData);
            }

            if (_rowGroups.TryGetValue(_lastSelectedId, out List<Panel> panelsOld)) {
                foreach (var item in panelsOld)
                    item.Tag = (isArrived) ? Color.FromArgb(46, 204, 113) : (isOverdue ? Color.FromArgb(231, 76, 60) : Color.Transparent);
            }
            

            return true;
        }
        public bool GetCurrentDataRow() {
            if (_lastSelectedId == -1)
                return false;
            using (var scope = _scopeFactory.CreateScope())
            {
                var queries = scope.ServiceProvider.GetRequiredService<DataBaseQueries>();
                _currentDataSelected.Current = queries.GetFunctionDataStockById(_lastSelectedId, _mainStock.Current.Id);
            }
            return true;
        }
        private void ClearRowCompletely() {
            foreach (var item in _rowGroups) {
                foreach (Panel panel in item.Value) {
                    while (panel.Controls.Count > 0) {
                        var ctrl = panel.Controls[0];
                        panel.Controls.RemoveAt(0);
                        ctrl.Dispose();
                    }
                    panel.Dispose();
                }
                _rowGroups.Remove(item.Key);
            }
        }
        private void UpdateEveryRow(List<FunctionStockData> data) {
            foreach (var item in data) {
                var currentColorForPanHolder = (item.isArrived) ? Color.FromArgb(46, 204, 113) : (item.isOverdue ? Color.FromArgb(231, 76, 60) : Color.Transparent);
                Label lbId = new Label { Name = "idLabel" , Text = item.Id.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Tag = item.Id };
                Label lbName = new Label { Name = "nameLabel", Text = item.NameOfGood, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Tag = item.Id };
                Label lbQuan = new Label { Name = "quantityLabel", Text = item.Quantity.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Tag = item.Id };
                Label lbData = new Label { Name = "dateLabel", Text = item.DateOfArrival.ToString("dd.MM.yyyy HH:mm"), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Tag = item.Id };
                Label lbPrice = new Label { Name = "priceLabel", Text = item.Price.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Tag = item.Id };

                Panel idPanHolder = new Panel{
                    BackColor = currentColorForPanHolder,
                    Margin = new Padding(0),
                    Size = new Size(_idPanel.Size.Width, 25),
                    AutoScroll = false,
                    Tag = currentColorForPanHolder
                };
                idPanHolder.Click += (s, e) => SelectRowGroup((int)lbId.Tag);
                lbId.Click += (s, e) => SelectRowGroup((int)lbId.Tag);
                idPanHolder.Controls.Add(lbId);

                Panel namePanHolder = new Panel {
                    BackColor = currentColorForPanHolder,
                    Margin = new Padding(0),
                    Size = new Size(_namePanel.Size.Width, 25),
                    AutoScroll = false,
                    Padding = new Padding(10, 0, 0, 0),
                    Tag = currentColorForPanHolder
                };
                namePanHolder.Click += (s, e) => SelectRowGroup((int)lbName.Tag);
                lbName.Click += (s, e) => SelectRowGroup((int)lbName.Tag);
                namePanHolder.Controls.Add(lbName);

                Panel quanPanHolder = new Panel {
                    BackColor = currentColorForPanHolder,
                    Margin = new Padding(0),
                    Size = new Size(_quantityPanel.Size.Width, 25),
                    AutoScroll = false,
                    Padding = new Padding(10, 0, 0, 0),
                    Tag = currentColorForPanHolder
                };
                quanPanHolder.Click += (s, e) => SelectRowGroup((int)lbQuan.Tag);
                lbQuan.Click += (s, e) => SelectRowGroup((int)lbQuan.Tag);
                quanPanHolder.Controls.Add(lbQuan);

                Panel dataPanHolder = new Panel {
                    BackColor = currentColorForPanHolder,
                    Margin = new Padding(0),
                    Size = new Size(_dataPanel.Size.Width, 25),
                    AutoScroll = false,
                    Padding = new Padding(10, 0, 0, 0),
                    Tag = currentColorForPanHolder
                };
                dataPanHolder.Click += (s, e) => SelectRowGroup((int)lbData.Tag);
                lbData.Click += (s, e) => SelectRowGroup((int)lbData.Tag);
                dataPanHolder.Controls.Add(lbData);

                Panel pricePanHolder = new Panel {
                    BackColor = currentColorForPanHolder,
                    Margin = new Padding(0),
                    Size = new Size(_pricePanel.Size.Width, 25),
                    AutoScroll = false,
                    Padding = new Padding(10, 0, 0, 0),
                    Tag = currentColorForPanHolder
                };
                pricePanHolder.Click += (s, e) => SelectRowGroup((int)lbPrice.Tag);
                lbPrice.Click += (s, e) => SelectRowGroup((int)lbPrice.Tag);
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
                        item.BackColor = (Color)item.Tag;
                }
                // Змінюємо колір у нових панелях
                if (_rowGroups.TryGetValue(Id, out List<Panel> panelsNew))
                {
                    foreach (var item in panelsNew)
                    {
                        item.Tag = item.BackColor;
                        item.BackColor = Color.LightBlue;
                    }

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
        public async Task<bool> DoSearch(int Index, string inputData) {
            using (var scope = _scopeFactory.CreateScope()) {
                var queries = scope.ServiceProvider.GetRequiredService<DataBaseQueries>();

                switch (Index)
                {
                    case 0:
                        if (!_validation.IsOnlyIntegers(inputData))
                            return false;
                        var searchedDataId = queries.GetFunctionDataStockById(int.TryParse(inputData, out int id) ? id : 0, _mainStock.Current.Id);
                        ClearRowCompletely();
                        UpdateEveryRow(searchedDataId == null ? new List<FunctionStockData>() : new List<FunctionStockData> { searchedDataId });
                        break;
                    case 1:
                        if (!_validation.IsValidNameGood(inputData))
                            return false;
                        var searchedDataName = await queries.SearchFunctionDataByName(inputData, _mainStock.Current.Id);
                        ClearRowCompletely();
                        UpdateEveryRow(searchedDataName);
                        break;
                    case 2:
                        if (!_validation.IsOnlyIntegers(inputData))
                            return false;
                        var searchedDataQuantity = await queries.SearchFunctionDataByQuantity(int.TryParse(inputData, out int quantity) ? quantity : 0, _mainStock.Current.Id);
                        ClearRowCompletely();
                        UpdateEveryRow(searchedDataQuantity);
                        break;
                    case 3:
                        if (!_validation.IsDate(inputData))
                            return false;
                        var searcgedDataDate = await queries.SearchFunctionDataByDate(DateTime.TryParseExact(inputData, "dd.MM.yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime date) ? date : DateTime.MinValue, _mainStock.Current.Id);
                        ClearRowCompletely();
                        UpdateEveryRow(searcgedDataDate);
                        break;
                    case 4:
                        if (!_validation.IsFloatPointInteger(inputData))
                            return false;
                        var searchedDataPrice = await queries.SearchFunctionDataByPrice(decimal.TryParse(inputData, out decimal price) ? price : 0.0M, _mainStock.Current.Id);
                        ClearRowCompletely();
                        UpdateEveryRow(searchedDataPrice);
                        break;
                    default:
                        MessageBox.Show("You didn't choose what column search by");
                        break;
                } 
            }
            return true;
        }
    }
}
