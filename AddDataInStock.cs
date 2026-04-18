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

namespace StockMaster
{
    public partial class AddDataInStock : Form
    {
        private ValidationService _validation;
        private DataBaseQueries _queries;
        public AddDataInStock(ValidationService validation, DataBaseQueries queries)
        {
            InitializeComponent();
            _validation = validation;
            _queries = queries;
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
            if (!_validation.IsValidName(nameOfGoodTextBox.Text))
            {
                MessageBox.Show("You entered incorrect name");
                return;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Перевіряється якщо клавіша не керуюча + клавіша не цифра + не кома то ми блокуємо ввід даних.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // Якщо знаходимо що кома вже була а ми питаємося ввести кому то блокуємо ввід даних.
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void AddDataInStock_Load(object sender, EventArgs e)
        {
            monthCalendar1.MinDate = DateTime.Today;
        }
    }
}
