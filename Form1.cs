using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using StockMaster.Classes.CardCreation;
using StockMaster.Classes.MoveForm;
using StockMaster.Data;
using StockMaster.Services;

namespace StockMaster
{
    public partial class Form1 : Form
    {
        DataBaseQueries _queries;
        ValidationService _validation;

        CardCreationInStocks cardStocks;


        public Form1(DataBaseQueries queries, ValidationService validation)
        {
            InitializeComponent();
            _queries = queries;
            _validation = validation;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFormClass.MoveForm(sender, e, this);
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

            if (!_queries.IsUserExist(new Models.User { UserName = userNameLogInBox.Text, UserPassword = passwordLogInBox.Text }))
            {
                MessageBox.Show("You entered wrong username or password.");
                return;
            }
            userNameShowlabel.Text = userNameLogInBox.Text;

            userNameLogInBox.Text = "";
            passwordLogInBox.Text = "";
        }

        private void SingUpButton_Click(object sender, EventArgs e)
        {
            if (!_validation.IsValidUserName(userNameSingUpBox.Text) || _queries.IsNameTaken(userNameSingUpBox.Text))
            {
                MessageBox.Show("You entered an incorrect username or username is already taken.");
                return;
            }

            var pas = passwordSingUpBox.Text;
            var pasC = passwordConfirmSingUpBox.Text;

            if (!_validation.IsValidPassword(pas) || !_validation.IsValidPassword(pasC) || pas != pasC)
            {
                MessageBox.Show("You entered an incorrect password.");
                return;
            }

            _queries.AddUser(new Models.User { UserName = userNameSingUpBox.Text, UserPassword = passwordSingUpBox.Text });

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

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (AddNewStockForm addNewStock = new AddNewStockForm())
            {
                if (addNewStock.ShowDialog() == DialogResult.OK)
                {
                    cardStocks.AddPanel();
                }
            }
        }
    }
}
