using Microsoft.Extensions.DependencyInjection;
using StockMaster.Classes;
using StockMaster.Classes.MoveForm;
using StockMaster.Forms.Quick;
using StockMaster.Models;
using StockMaster.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StockMaster.Forms.ShowData
{
    public partial class StockDataPhysicStockShowForm : Form
    {
        private StockStorage _mainStock;
        private IServiceProvider _serviceProvider;
        private ShowPhysicDataInStockClass _showDataInStock;
        public StockDataPhysicStockShowForm(StockStorage stock, IServiceProvider serviceProvider, ShowPhysicDataInStockClass showDataInStock)
        {
            InitializeComponent();
            _mainStock = stock;
            _serviceProvider = serviceProvider;
            _showDataInStock = showDataInStock;

            showDataInStock.Init(new List<Panel> { flowLayoutPanelId, flowLayoutPanelNameOfGood, flowLayoutPanelQuantity });
        }

        private void closeFormButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFormClass.MoveForm(sender, e, this);
        }

        private async void StockDataPhysicStockShowForm_Load(object sender, EventArgs e)
        {
            inputDataTextBox.Text = "";
            searchByComboBox.SelectedIndex = -1;
            searchByComboBox.Text = "Search by";

            flowLayoutPanelId.BackColor = ColorTranslator.FromHtml("#B3E5FC");
            flowLayoutPanelNameOfGood.BackColor = ColorTranslator.FromHtml("#A5D4F0");
            flowLayoutPanelQuantity.BackColor = ColorTranslator.FromHtml("#B3E5FC");
            flowLayoutPanelStockInfo.BackColor = Color.FromArgb(128, 135, 215, 255);

            nameOfStockLabel.Text = _mainStock.Current.StockName;
            accessStock.Text = _mainStock.Current.AccessStock == AccessOfStocks.Private ? "Private" : "Public";

            await _showDataInStock.UpdateDataTableWithNewData();
        }

        private async void addDataButton_Click(object sender, EventArgs e)
        {
            using (var addNewDataStock = _serviceProvider.GetRequiredService<AddPhysicDataInStock>())
            {
                if (addNewDataStock.ShowDialog() == DialogResult.OK)
                {
                    await _showDataInStock.UpdateDataTableWithNewData();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void deleteDataButton_Click(object sender, EventArgs e)
        {
            if (!_showDataInStock.DeleteCurrentDataRow())
            {
                MessageBox.Show("You don't choose data to update");
                return;
            }
            await _showDataInStock.UpdateDataTableWithNewData();
        }

        private async void updateDataButton_Click(object sender, EventArgs e)
        {
            if (!_showDataInStock.GetCurrentDataRow())
            {
                MessageBox.Show("You don't choose data to update");
                return;
            }
            using (var updateDataForStock = _serviceProvider.GetRequiredService<UpdatePhysicStockData>())
            {
                if (updateDataForStock.ShowDialog() == DialogResult.OK)
                {
                    await _showDataInStock.UpdateDataTableWithNewData();
                }
            }
        }
    }
}
