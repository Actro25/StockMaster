using StockMaster.Classes.MoveForm;
using StockMaster.Data;
using StockMaster.Services;
using System;
using System.Windows.Forms;

namespace StockMaster.Forms.Quick
{
    public partial class AddPhysicDataInStock : Form
    {
        private ValidationService _validation;
        private DataBaseQueries _queries;
        private StockStorage _mainStock;
        public AddPhysicDataInStock(ValidationService validation, DataBaseQueries queries, StockStorage stock)
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

        private void cancelButton_Click(object sender, EventArgs e)
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

            _queries.AddPhysicDataStock(new Models.PhysicStockData
            {
                NameOfGood = nameOfGoodTextBox.Text,
                Quantity = (int)quantityNumericUpDown.Value,
                StockId = _mainStock.Current.Id
            });

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
