using Microsoft.Extensions.DependencyInjection;
using StockMaster.Abstract;
using StockMaster.Data;
using StockMaster.Interfaces;
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
    public class ShowFunctionDataInStockClass : BaseDataToReflectInForm<FunctionStockData>, IAdvancedSortable
    {
        private FunctionalDataStorage _currentDataSelected;
        public ShowFunctionDataInStockClass(IServiceScopeFactory scopeFactory, StockStorage mainStock, 
            FunctionalDataStorage currentDataSelected, ValidationService validation) : base(scopeFactory, mainStock, validation)
        {
            _currentDataSelected = currentDataSelected;
        }
        
        public override async Task UpdateDataTableWithNewData() {
            ClearRowCompletely();
            using (var scopedQueries = _scopeFactory.CreateScope()) {
                var queries = scopedQueries.ServiceProvider.GetRequiredService<DataBaseQueries>();
                var temp = await queries.GetAllFunctionDataStocksById(_mainStock.Current.Id);
                UpdateEveryRow(temp);
            }
        }

        public override bool DeleteCurrentDataRow() {
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
        
        public override bool GetCurrentDataRow() {
            if (_lastSelectedId == -1)
                return false;
            using (var scope = _scopeFactory.CreateScope())
            {
                var queries = scope.ServiceProvider.GetRequiredService<DataBaseQueries>();
                _currentDataSelected.Current = queries.GetFunctionDataStockById(_lastSelectedId, _mainStock.Current.Id);
            }
            return true;
        }
        
        protected override void UpdateEveryRow(List<FunctionStockData> data) {
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
                    Size = new Size(BasePanels[0].Size.Width, 25),
                    AutoScroll = false,
                    Tag = currentColorForPanHolder
                };
                idPanHolder.Click += (s, e) => SelectRowGroup((int)lbId.Tag);
                lbId.Click += (s, e) => SelectRowGroup((int)lbId.Tag);
                idPanHolder.Controls.Add(lbId);

                Panel namePanHolder = new Panel {
                    BackColor = currentColorForPanHolder,
                    Margin = new Padding(0),
                    Size = new Size(BasePanels[1].Size.Width, 25),
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
                    Size = new Size(BasePanels[2].Size.Width, 25),
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
                    Size = new Size(BasePanels[3].Size.Width, 25),
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
                    Size = new Size(BasePanels[4].Size.Width, 25),
                    AutoScroll = false,
                    Padding = new Padding(10, 0, 0, 0),
                    Tag = currentColorForPanHolder
                };
                pricePanHolder.Click += (s, e) => SelectRowGroup((int)lbPrice.Tag);
                lbPrice.Click += (s, e) => SelectRowGroup((int)lbPrice.Tag);
                pricePanHolder.Controls.Add(lbPrice);

                

                _rowGroups.Add(item.Id, new List<Panel> { idPanHolder, namePanHolder, quanPanHolder, dataPanHolder, pricePanHolder });

                BasePanels[0].Controls.Add(idPanHolder);
                BasePanels[1].Controls.Add(namePanHolder);
                BasePanels[2].Controls.Add(quanPanHolder);
                BasePanels[3].Controls.Add(dataPanHolder);
                BasePanels[4].Controls.Add(pricePanHolder);
            }
        }
        
        public void SortDataByDateColumn(bool isFromHigher) {
            _rowGroups = SortPanelDataService.SortByDate(_rowGroups, isFromHigher);
            RefreshDataTable();
        }
        
        public void SortDataByPriceColumn(bool isFromHigher) {
            _rowGroups = SortPanelDataService.SortByPrice(_rowGroups, isFromHigher);
            RefreshDataTable();
        }
        
        public override async Task<bool> DoSearch(int Index, string inputData) {
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
