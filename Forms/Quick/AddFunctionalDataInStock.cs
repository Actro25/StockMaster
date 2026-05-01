using StockMaster.Classes.MoveForm;
using StockMaster.Data;
using StockMaster.Models;
using StockMaster.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StockMaster
{
    public partial class AddFunctionalDataInStock : Form
    {
        private ValidationService _validation;
        private DataBaseQueries _queries;
        private StockStorage _mainStock;
        public AddFunctionalDataInStock(ValidationService validation, DataBaseQueries queries, StockStorage stock)
        {
            InitializeComponent();
            _validation = validation;
            _queries = queries;
            _mainStock = stock;
        }

        private void closeFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFormClass.MoveForm(sender, e, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (!_validation.IsValidNameGood(nameOfGoodTextBox.Text))
            {
                MessageBox.Show("You entered incorrect name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (priceTextBox.Text == "")
            {
                MessageBox.Show("You don't enter price for your data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _queries.AddFunctionStockData(new Models.FunctionStockData
            {
                NameOfGood = nameOfGoodTextBox.Text,
                Quantity = (int)quantityNumericUpDown.Value,
                DateOfArrival = dateTimePicker1.Value,
                Price = Convert.ToDecimal(priceTextBox.Text),
                StockId = _mainStock.Current.Id
            });
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                e.Handled = true;
        }

        private void AddDataInStock_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker1.ShowUpDown = true;
        }
    }
}
