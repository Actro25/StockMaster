using StockMaster.Classes.MoveForm;
using StockMaster.Data;
using StockMaster.Services;
using System;
using System.Windows.Forms;

namespace StockMaster.Forms.Quick
{
    public partial class UpdateFunctionalStockData : Form
    {
        private FunctionalDataStorage _currentData;
        private DataBaseQueries _queries;
        private ValidationService _validation;
        public UpdateFunctionalStockData(FunctionalDataStorage currentData, DataBaseQueries queries, ValidationService validation)
        {
            InitializeComponent();
            _currentData = currentData;
            _queries = queries;
            _validation = validation;
        }

        private void DeleteFunctionalStockData_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker1.ShowUpDown = true;

            dateTimePicker1.Value = _currentData.Current.DateOfArrival;
            nameOfGoodTextBox.Text = _currentData.Current.NameOfGood;
            quantityNumericUpDown.Value = _currentData.Current.Quantity;
            priceTextBox.Text = _currentData.Current.Price.ToString();
        }

        private void closeFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFormClass.MoveForm(sender, e, this);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
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
            _queries.UpdateFunctionDataStock(new Models.FunctionStockData
            {
                Id = _currentData.Current.Id,
                NameOfGood = nameOfGoodTextBox.Text,
                Quantity = (int)quantityNumericUpDown.Value,
                DateOfArrival = dateTimePicker1.Value,
                Price = Convert.ToDecimal(priceTextBox.Text),
                StockId = _currentData.Current.StockId,
                MainStock = _currentData.Current.MainStock,
                isArrived = _currentData.Current.isArrived,
                isOverdue = _currentData.Current.isOverdue
            });
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                e.Handled = true;
        }
    }
}
