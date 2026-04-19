using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using StockMaster.Classes;
using StockMaster.Classes.MoveForm;
using StockMaster.Models;
using StockMaster.Services;
namespace StockMaster
{
    public partial class StockDataShowForm : Form
    {
        private IServiceProvider _serviceProvider;
        private StockStorage _mainStock;
        private ShowDataInStockClass _showDataInStock;
        public StockDataShowForm(IServiceProvider serviceProvider, StockStorage stock, ShowDataInStockClass showDataInStock)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _mainStock = stock;
            _showDataInStock = showDataInStock;

            _showDataInStock.Init(flowLayoutPanelId, flowLayoutPanelNameOfGood, flowLayoutPanelQuantity, flowLayoutPanelDateOfArrival, flowLayoutPanelPrice);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFormClass.MoveForm(sender, e, this);
        }
        private void closeFormButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private async void addDataButton_Click(object sender, EventArgs e)
        {
            using (var addNewDataStock = _serviceProvider.GetRequiredService<AddDataInStock>())
            {
                if (addNewDataStock.ShowDialog() == DialogResult.OK)
                {
                    await _showDataInStock.UpdateDataTable();
                }
            }
        }

        private async void StockDataShowForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanelId.BackColor = ColorTranslator.FromHtml("#B3E5FC");
            flowLayoutPanelNameOfGood.BackColor = ColorTranslator.FromHtml("#A5D4F0");
            flowLayoutPanelQuantity.BackColor = ColorTranslator.FromHtml("#B3E5FC");
            flowLayoutPanelDateOfArrival.BackColor = ColorTranslator.FromHtml("#A5D4F0");
            flowLayoutPanelPrice.BackColor = ColorTranslator.FromHtml("#B3E5FC");
            flowLayoutPanelStockInfo.BackColor = Color.FromArgb(128, 135, 215, 255);

            await _showDataInStock.UpdateDataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void deleteDataButton_Click(object sender, EventArgs e)
        {

        }
    }
}
