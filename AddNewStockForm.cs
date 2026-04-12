using StockMaster.Classes.CardCreation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StockMaster.Classes.MoveForm;

namespace StockMaster
{
    public partial class AddNewStockForm : Form
    {
        CardCreationInStocks cardStocks;

        public AddNewStockForm()
        {
            InitializeComponent();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFormClass.MoveForm(sender, e, this);
        }
        private void AddNewStockForm_Load(object sender, EventArgs e)
        {
            chooseTypeOfStock.DataSource = Enum.GetValues(typeof(TypeOfStocks));
        }

        private void closeFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (confirmPasswordTextBox.Text == "")
                return;


            if (confirmPasswordTextBox.Text == passwordTextBox.Text)
            {
                infoPasswordLabel.Text = "Паролі сходяться";
                infoPasswordLabel.ForeColor = Color.Green;
            }
            else {
                infoPasswordLabel.Text = "Паролі несходяться";
                infoPasswordLabel.ForeColor = Color.Red;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "") 
                return;
            if (confirmPasswordTextBox.Text != "" && (confirmPasswordTextBox.Text == passwordTextBox.Text))
            {
                infoPasswordLabel.Text = "Паролі сходяться";
                infoPasswordLabel.ForeColor = Color.Green;
            }
            else
            {
                infoPasswordLabel.Text = "Паролі несходяться";
                infoPasswordLabel.ForeColor = Color.Red;
            }
        }

        private void privatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            accessPrivatePanel.Visible = true;
        }

        private void publicRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            accessPrivatePanel.Visible = false;
        }

        enum TypeOfStocks { 
            FunctionalStock,
            PhysicalStock,
        }
        private void chooseTypeOfStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeOfStocks typeStock = (TypeOfStocks)chooseTypeOfStock.SelectedItem;
            importantTextPanel.Visible = true;
            switch (typeStock) {
                case TypeOfStocks.FunctionalStock:
                    infoStockLabel.Text = "Цей склад підходить більше для обліку партій і матеріалів.";
                    break;
                case TypeOfStocks.PhysicalStock:
                    infoStockLabel.Text = "Цей склад підходить більше для зберігання товарів. ";
                    break;
            }
            
        }

        private void denyButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameOfStock.Text == "")
            {
                MessageBox.Show("Ви не ввели назву склада.","",MessageBoxButtons.OK);
                return;
            }
            if (privatRadioButton.Checked && ((passwordTextBox.Text != confirmPasswordTextBox.Text) || (passwordTextBox.Text == "" && confirmPasswordTextBox.Text == ""))) {
                MessageBox.Show("Ваші паролі незбігаються.", "", MessageBoxButtons.OK);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }


    }
}
