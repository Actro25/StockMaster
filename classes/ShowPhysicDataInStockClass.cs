using Microsoft.Extensions.DependencyInjection;
using StockMaster.Abstract;
using StockMaster.Data;
using StockMaster.Models;
using StockMaster.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMaster.Classes
{
    public class ShowPhysicDataInStockClass : BaseDataToReflectInForm<PhysicStockData>
    {
        private PhysicDataStorage _currentDataSelected;
        public ShowPhysicDataInStockClass(IServiceScopeFactory scopeFactory, StockStorage mainStock, 
            ValidationService validation, PhysicDataStorage currentDataSelected) : base(scopeFactory, mainStock, validation) 
        {
            _currentDataSelected = currentDataSelected;
        }
        public override bool GetCurrentDataRow()
        {
            if (_lastSelectedId == -1)
                return false;
            using (var scope = _scopeFactory.CreateScope())
            {
                var queries = scope.ServiceProvider.GetRequiredService<DataBaseQueries>();
                _currentDataSelected.Current = queries.GetPhysicDataStockById(_lastSelectedId, _mainStock.Current.Id);
            }
            return true;
        }
        public override bool DeleteCurrentDataRow()
        {
            if (_lastSelectedId == -1)
                return false;
            using (var scope = _scopeFactory.CreateScope())
            {
                var queries = scope.ServiceProvider.GetRequiredService<DataBaseQueries>();
                queries.DeletePhysicDataById(_lastSelectedId);
            }
            return true;
        }

        public override async Task UpdateDataTableWithNewData()
        {
            ClearRowCompletely();
            using (var scopedQueries = _scopeFactory.CreateScope())
            {
                var queries = scopedQueries.ServiceProvider.GetRequiredService<DataBaseQueries>();
                var temp = await queries.GetAllPhysicDataStockById(_mainStock.Current.Id);
                UpdateEveryRow(temp);
            }
        }

        public override Task<bool> DoSearch(int Index, string inputData)
        {
            throw new NotImplementedException();
        }

        protected override void UpdateEveryRow(List<PhysicStockData> data)
        {
            foreach (var item in data) {
                Label lbId = new Label { Name = "idLabel", Text = item.Id.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Tag = item.Id };
                Label lbName = new Label { Name = "nameLabel", Text = item.NameOfGood, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Tag = item.Id };
                Label lbQuan = new Label { Name = "quantityLabel", Text = item.Quantity.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Tag = item.Id };

                Panel idPanHolder = new Panel
                {
                    BackColor = Color.Transparent,
                    Margin = new Padding(0),
                    Size = new Size(BasePanels[0].Size.Width, 25),
                    AutoScroll = false,
                    Tag = Color.Transparent
                };
                idPanHolder.Click += (s, e) => SelectRowGroup((int)lbId.Tag);
                lbId.Click += (s, e) => SelectRowGroup((int)lbId.Tag);
                idPanHolder.Controls.Add(lbId);

                Panel namePanHolder = new Panel
                {
                    BackColor = Color.Transparent,
                    Margin = new Padding(0),
                    Size = new Size(BasePanels[1].Size.Width, 25),
                    AutoScroll = false,
                    Padding = new Padding(10, 0, 0, 0),
                    Tag = Color.Transparent
                };
                namePanHolder.Click += (s, e) => SelectRowGroup((int)lbName.Tag);
                lbName.Click += (s, e) => SelectRowGroup((int)lbName.Tag);
                namePanHolder.Controls.Add(lbName);

                Panel quanPanHolder = new Panel
                {
                    BackColor = Color.Transparent,
                    Margin = new Padding(0),
                    Size = new Size(BasePanels[2].Size.Width, 25),
                    AutoScroll = false,
                    Padding = new Padding(10, 0, 0, 0),
                    Tag = Color.Transparent
                };
                quanPanHolder.Click += (s, e) => SelectRowGroup((int)lbQuan.Tag);
                lbQuan.Click += (s, e) => SelectRowGroup((int)lbQuan.Tag);
                quanPanHolder.Controls.Add(lbQuan);

                _rowGroups.Add(item.Id, new List<Panel> { idPanHolder, namePanHolder, quanPanHolder });

                BasePanels[0].Controls.Add(idPanHolder);
                BasePanels[1].Controls.Add(namePanHolder);
                BasePanels[2].Controls.Add(quanPanHolder);
            }
        }
    }
}
