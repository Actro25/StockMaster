using StockMaster.Classes;
using StockMaster.Classes.MoveForm;
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
        public StockDataPhysicStockShowForm(StockStorage stock)
        {
            InitializeComponent();
            _mainStock = stock;
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

        private void StockDataPhysicStockShowForm_Load(object sender, EventArgs e)
        {
            inputDataTextBox.Text = "";
            searchByComboBox.SelectedIndex = -1;
            searchByComboBox.Text = "Search by";

            flowLayoutPanelId.BackColor = ColorTranslator.FromHtml("#B3E5FC");
            flowLayoutPanelNameOfGood.BackColor = ColorTranslator.FromHtml("#A5D4F0");
            flowLayoutPanelQuantity.BackColor = ColorTranslator.FromHtml("#B3E5FC");

            nameOfStockLabel.Text = _mainStock.Current.StockName;
            accessStock.Text = _mainStock.Current.AccessStock == AccessOfStocks.Private ? "Private" : "Public";
        }
    }
}
