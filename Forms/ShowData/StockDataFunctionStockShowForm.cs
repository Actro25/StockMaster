using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using StockMaster.Classes;
using StockMaster.Classes.MoveForm;
using StockMaster.Forms.Quick;
using StockMaster.Models;
using StockMaster.Services;
namespace StockMaster
{
    public partial class StockDataFunctionStockShowForm : Form
    {
        /*
            ЗАДВАННЯ:
            1)Зробити можливість обновляти стоки (добавити кнопку з фоткою cog)
            2)Подумати над швидкою сортировкою або пошуком за введеними данними.
         */
        private IServiceProvider _serviceProvider;
        private StockStorage _mainStock;
        private ShowDataInStockClass _showDataInStock;
        public StockDataFunctionStockShowForm(IServiceProvider serviceProvider, StockStorage stock, ShowDataInStockClass showDataInStock)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _mainStock = stock;
            _showDataInStock = showDataInStock;

            _showDataInStock.Init(new List<Panel> { flowLayoutPanelId, flowLayoutPanelNameOfGood, flowLayoutPanelQuantity, flowLayoutPanelDateOfArrival, flowLayoutPanelPrice });
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
            using (var addNewDataStock = _serviceProvider.GetRequiredService<AddFunctionalDataInStock>())
            {
                if (addNewDataStock.ShowDialog() == DialogResult.OK)
                {
                    await _showDataInStock.UpdateDataTableWithNewData();
                }
            }
        }

        private async void StockDataShowForm_Load(object sender, EventArgs e)
        {
            inputDataTextBox.Text = "";
            searchByComboBox.SelectedIndex = -1;
            searchByComboBox.Text = "Search by";

            flowLayoutPanelId.BackColor = ColorTranslator.FromHtml("#B3E5FC");
            flowLayoutPanelNameOfGood.BackColor = ColorTranslator.FromHtml("#A5D4F0");
            flowLayoutPanelQuantity.BackColor = ColorTranslator.FromHtml("#B3E5FC");
            flowLayoutPanelDateOfArrival.BackColor = ColorTranslator.FromHtml("#A5D4F0");
            flowLayoutPanelPrice.BackColor = ColorTranslator.FromHtml("#B3E5FC");
            flowLayoutPanelStockInfo.BackColor = Color.FromArgb(128, 135, 215, 255);

            nameOfStockLabel.Text = _mainStock.Current.StockName;
            accessStock.Text = _mainStock.Current.AccessStock == AccessOfStocks.Private ? "Private" : "Public";

            await _showDataInStock.UpdateDataTableWithNewData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void deleteDataButton_Click(object sender, EventArgs e)
        {
            if (!_showDataInStock.GetCurrentDataRow())
            {
                MessageBox.Show("You don't choose data to update");
                return;
            }
        }
        private async void updateDataButton_Click(object sender, EventArgs e)
        {
            if (!_showDataInStock.GetCurrentDataRow())
            {
                MessageBox.Show("You don't choose data to update");
                return;
            }
            using (var updateDataForStock = _serviceProvider.GetRequiredService<UpdateFunctionalStockData>())
            {
                if (updateDataForStock.ShowDialog() == DialogResult.OK)
                {
                    await _showDataInStock.UpdateDataTableWithNewData();
                }
            }
        }

        private async void deleteDataButton_Click_1(object sender, EventArgs e)
        {
            if (!_showDataInStock.DeleteCurrentDataRow())
            {
                MessageBox.Show("You don't choose data to update");
                return;
            }
            await _showDataInStock.UpdateDataTableWithNewData();
        }

        private void idUpperLabel_Click(object sender, EventArgs e)
        {
            if (bool.TryParse(idUpperLabel.Tag?.ToString() ?? "", out bool isFromHiger))
            {
                _showDataInStock.SortDataByIdColumn(isFromHiger);
                idUpperLabel.Tag = isFromHiger ? "false" : "true";
                idUpperLabel.Text = isFromHiger ? "Id▼" : "Id▲";
                nameOfGoodsUpperLabel.Text = "Name of good";
                quantityUpperLabel.Text = "Quantity";
                dataOfArrivalUpperLabel.Text = "Date of arrival";
                priceUpperLabel.Text = "Price";
            }
        }

        private void nameOfGoodsUpperLabel_Click(object sender, EventArgs e)
        {
            if (bool.TryParse(nameOfGoodsUpperLabel.Tag?.ToString() ?? "", out bool isFromHiger))
            {
                _showDataInStock.SortDataByNameColumn(isFromHiger);
                nameOfGoodsUpperLabel.Tag = isFromHiger ? "false" : "true";
                nameOfGoodsUpperLabel.Text = isFromHiger ? "Name of good▼" : "Name of good▲";
                idUpperLabel.Text = "Id";
                quantityUpperLabel.Text = "Quantity";
                dataOfArrivalUpperLabel.Text = "Date of arrival";
                priceUpperLabel.Text = "Price";
            }
        }

        private void quantityUpperLabel_Click(object sender, EventArgs e)
        {
            if (bool.TryParse(quantityUpperLabel.Tag?.ToString() ?? "", out bool isFromHiger))
            {
                _showDataInStock.SortDataByQuantityColumn(isFromHiger);
                quantityUpperLabel.Tag = isFromHiger ? "false" : "true";
                quantityUpperLabel.Text = isFromHiger ? "Quantity▼" : "Quantity▲";
                idUpperLabel.Text = "Id";
                nameOfGoodsUpperLabel.Text = "Name of good";
                dataOfArrivalUpperLabel.Text = "Date of arrival";
                priceUpperLabel.Text = "Price";
            }

        }

        private void dataOfArrivalUpperLabel_Click(object sender, EventArgs e)
        {
            if (bool.TryParse(dataOfArrivalUpperLabel.Tag?.ToString() ?? "", out bool isFromHiger))
            {
                _showDataInStock.SortDataByDateColumn(isFromHiger);
                dataOfArrivalUpperLabel.Tag = isFromHiger ? "false" : "true";
                dataOfArrivalUpperLabel.Text = isFromHiger ? "Date of arrival▼" : "Date of arrival▲";
                idUpperLabel.Text = "Id";
                nameOfGoodsUpperLabel.Text = "Name of good";
                quantityUpperLabel.Text = "Quantity";
                priceUpperLabel.Text = "Price";
            }
        }

        private void priceUpperLabel_Click(object sender, EventArgs e)
        {
            if (bool.TryParse(priceUpperLabel.Tag?.ToString() ?? "", out bool isFromHiger))
            {
                _showDataInStock.SortDataByPriceColumn(isFromHiger);
                priceUpperLabel.Tag = isFromHiger ? "false" : "true";
                priceUpperLabel.Text = isFromHiger ? "Price▼" : "Price▲";
                idUpperLabel.Text = "Id";
                nameOfGoodsUpperLabel.Text = "Name of good";
                quantityUpperLabel.Text = "Quantity";
                dataOfArrivalUpperLabel.Text = "Date of arrival";
            }
        }

        private void arrivedButton_Click(object sender, EventArgs e)
        {
            if (!_showDataInStock.ArrivedOrOverdueCurrentDataRow(true, false))
            {
                MessageBox.Show("You don't choose data to update");
                return;
            }
        }

        private void overdueButton_Click(object sender, EventArgs e)
        {
            if (!_showDataInStock.ArrivedOrOverdueCurrentDataRow(false, true))
            {
                MessageBox.Show("You don't choose data to update");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!_showDataInStock.ArrivedOrOverdueCurrentDataRow(false, false))
            {
                MessageBox.Show("You don't choose data to update");
                return;
            }
        }

        private async void searchDataButton_Click(object sender, EventArgs e)
        {
            if (!(await _showDataInStock.DoSearch(searchByComboBox.SelectedIndex, inputDataTextBox.Text)))
            {
                MessageBox.Show("You entered incorrect data.");
                return;
            }
        }

        private async void clearShearchButton_Click(object sender, EventArgs e)
        {
            inputDataTextBox.Text = "";
            searchByComboBox.SelectedIndex = -1;
            searchByComboBox.Text = "Search by";
            await _showDataInStock.UpdateDataTableWithNewData();
        }
    }
}
