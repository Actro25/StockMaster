using StockMaster.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace StockMaster
{
    public partial class AddNewStockForm : Form
    {
        CardCreationInStocks cardStocks;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int WParam, int lParam);

        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }
        public AddNewStockForm()
        {
            InitializeComponent();
        }
        private void AddNewStockForm_Load(object sender, EventArgs e)
        {
            chooseTypeOfStock.DataSource = Enum.GetValues(typeof(TypeOfStocks));
        }

        private void closeFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        string password;
        string confpassword;
        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (confirmPasswordTextBox.Text == "")
                return;

            confpassword = confirmPasswordTextBox.Text;

            if (confpassword == password)
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
            password = passwordTextBox.Text;
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
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
