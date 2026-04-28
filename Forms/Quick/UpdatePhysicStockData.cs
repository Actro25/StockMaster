using StockMaster.Classes.MoveForm;
using StockMaster.Data;
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

namespace StockMaster.Forms.Quick
{

    public partial class UpdatePhysicStockData : Form
    {
        private PhysicDataStorage _currentData;
        private DataBaseQueries _queries;
        private ValidationService _validation;
        public UpdatePhysicStockData(PhysicDataStorage currentData, DataBaseQueries queries, ValidationService validation)
        {
            InitializeComponent();
            _currentData = currentData;
            _queries = queries;
            _validation = validation;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFormClass.MoveForm(sender, e, this);
        }

        private void UpdatePhysicStockData_Load(object sender, EventArgs e)
        {
            nameOfGoodTextBox.Text = _currentData.Current.NameOfGood;
            quantityNumericUpDown.Value = _currentData.Current.Quantity;
        }

        private void closeFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (!_validation.IsValidNameGood(nameOfGoodTextBox.Text))
            {
                MessageBox.Show("You entered incorrect name.");
                return;
            }
            _queries.UpdatePhysicDataStock(new Models.PhysicStockData
            {
                Id = _currentData.Current.Id,
                NameOfGood = nameOfGoodTextBox.Text,
                Quantity = (int)quantityNumericUpDown.Value,
                StockId = _currentData.Current.StockId,
                MainStock = _currentData.Current.MainStock,
            });
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
