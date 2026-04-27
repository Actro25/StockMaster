using Microsoft.Extensions.DependencyInjection;
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
using StockMaster.Interfaces;

namespace StockMaster.Abstract
{
    public abstract class BaseDataToReflectInForm<T> : IBasicSortable where T : BaseDataStock 
    {
        protected IServiceScopeFactory _scopeFactory;

        protected StockStorage _mainStock;

        protected ValidationService _validation;

        protected Dictionary<int, List<Panel>> _rowGroups = new Dictionary<int, List<Panel>>();

        protected int _lastSelectedId = -1;

        protected List<Panel> BasePanels = new List<Panel>();
        
        protected BaseDataToReflectInForm(IServiceScopeFactory scopeFactory, StockStorage mainStock, ValidationService validation)
        {
            _scopeFactory = scopeFactory;
            _mainStock = mainStock;
            _validation = validation;
        }
        
        public void Init(List<Panel> tablePanels) => BasePanels = tablePanels;

        public void SortDataByIdColumn(bool isFromHigher)
        {
            _rowGroups = SortPanelDataService.SortById(_rowGroups, isFromHigher);
            RefreshDataTable();
        }

        public void SortDataByNameColumn(bool isFromHigher)
        {
            _rowGroups = SortPanelDataService.SortByName(_rowGroups, isFromHigher);
            RefreshDataTable();
        }

        public void SortDataByQuantityColumn(bool isFromHigher)
        {
            _rowGroups = SortPanelDataService.SortByQuantity(_rowGroups, isFromHigher);
            RefreshDataTable();
        }

        public abstract bool GetCurrentDataRow();

        public abstract bool DeleteCurrentDataRow();

        public abstract Task UpdateDataTableWithNewData();

        public abstract Task<bool> DoSearch(int Index, string inputData);

        protected abstract void UpdateEveryRow(List<T> data);

        protected void ClearRowCompletely() {
            foreach (var item in _rowGroups)
            {
                foreach (Panel panel in item.Value)
                {
                    while (panel.Controls.Count > 0)
                    {
                        var ctrl = panel.Controls[0];
                        panel.Controls.RemoveAt(0);
                        ctrl.Dispose();
                    }
                    panel.Dispose();
                }
                _rowGroups.Remove(item.Key);
            }
        }

        protected void SelectRowGroup(int Id) {
            foreach (var item in BasePanels)
                item.SuspendLayout();
            try
            {
                if (_lastSelectedId != -1 && _rowGroups.TryGetValue(_lastSelectedId, out List<Panel> panelsOld))
                {
                    foreach (var item in panelsOld)
                        item.BackColor = (Color)item.Tag;
                }
                if (_rowGroups.TryGetValue(Id, out List<Panel> panelsNew))
                {
                    foreach (var item in panelsNew)
                    {
                        // Це було залишено для автоматичної сумісності в двох класах
                        item.Tag = item.BackColor;
                        item.BackColor = Color.LightBlue;
                    }

                    _lastSelectedId = Id;
                }
            }
            finally
            {
                foreach (var item in BasePanels)
                    item.ResumeLayout();
            }
        }

        protected void RefreshDataTable() {
            foreach (var item in BasePanels)
                item.SuspendLayout();
            try
            {
                foreach (var item in _rowGroups)
                {
                    for (int i = 0; i < BasePanels.Count; i++)
                        BasePanels[i].Controls.Add(item.Value[i]);
                }
            }
            finally
            {
                foreach (var item in BasePanels)
                    item.ResumeLayout();
            }
        }
    }
}
