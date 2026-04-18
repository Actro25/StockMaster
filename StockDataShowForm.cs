using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using StockMaster.Classes.MoveForm;
using StockMaster.Models;
using StockMaster.Services;
namespace StockMaster
{
    public partial class StockDataShowForm : Form
    {
        private IServiceProvider _serviceProvider;
        private StockStorage _mainStock;
        public StockDataShowForm(IServiceProvider serviceProvider, StockStorage stock)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _mainStock = stock;
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

        private void addDataButton_Click(object sender, EventArgs e)
        {
            using (var addNewDataStock = _serviceProvider.GetRequiredService<AddDataInStock>()) {
                if (addNewDataStock.ShowDialog() == DialogResult.OK) {
                    
                }
            }
/*            for (int i = 0; i < 10; i++)
            {
                var temp1 = new Label()
                {
                    Text = "Apple"
                };
                var temp2 = new Label()
                {
                    Text = "Banne"
                };
                var temp3 = new Label()
                {
                    Text = "Cherry"
                };
                var temp4 = new Label()
                {
                    Text = "Coconut"
                };
                var temp5 = new Label()
                {
                    Text = "Blubbery"
                };
                flowLayoutPanelId.Controls.AddRange(temp1);
                flowLayoutPanelId.Controls.AddRange(temp2);
                flowLayoutPanelId.Controls.AddRange(temp3);
                flowLayoutPanelId.Controls.AddRange(temp4);
                flowLayoutPanelId.Controls.AddRange(temp5);*/
        }

        private void StockDataShowForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanelId.BackColor = ColorTranslator.FromHtml("#B3E5FC");
            flowLayoutPanelNameOfGood.BackColor = ColorTranslator.FromHtml("#A5D4F0");
            flowLayoutPanelQuantity.BackColor = ColorTranslator.FromHtml("#B3E5FC");
            flowLayoutPanelDateOfArrival.BackColor = ColorTranslator.FromHtml("#A5D4F0");
            flowLayoutPanelPrice.BackColor = ColorTranslator.FromHtml("#B3E5FC");
            flowLayoutPanelStockInfo.BackColor = Color.FromArgb(128, 135, 215, 255);
        }
    }
}
