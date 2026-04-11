using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using StockMaster.classes;

namespace StockMaster
{
    public partial class Form1 : Form
    {
        CardCreationInStocks cardStocks;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int WParam, int lParam);

        private void MoveForm(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(this.Handle,0x112,0xf012,0);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cardStocks = new CardCreationInStocks(flowLayoutPanel1, this);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {

            userNameShowlabel.Text = userNameLogInBox.Text;

            userNameLogInBox.Text = "";
            passwordLogInBox.Text = "";
        }

        private void SingUpButton_Click(object sender, EventArgs e)
        {
            if (passwordConfirmSingUpBox.Text != passwordSingUpBox.Text) {
                MessageBox.Show("You entered an incorrect password, or the username is already taken");
                return;
            }
            userNameSingUpBox.Text = "";
            passwordSingUpBox.Text = "";
            passwordConfirmSingUpBox.Text = "";
        }

        private void exitFromAccountButton_Click(object sender, EventArgs e)
        {
            if (userNameShowlabel.Text == "none")
                MessageBox.Show("First, you need to log in to your account\r" +
                    "If you don't have an account, please sign up");
            userNameShowlabel.Text = "none";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (AddNewStockForm addNewStock = new AddNewStockForm()) {
                if (addNewStock.ShowDialog() == DialogResult.OK) {
                    cardStocks.AddPanel();
                }
            }
        }
        
    }
}
