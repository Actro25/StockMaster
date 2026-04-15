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
using StockMaster.Models;
using StockMaster.Classes;
using StockMaster.Services;
using StockMaster.Data;

namespace StockMaster
{
    public partial class AddNewStockForm : Form
    {
        UserSession _userSession;
        ValidationService _validation;
        DataBaseQueries _queries;

        /*
            ЗАВДАННЯ НА ЗАВТРА:
            Треба підкоректувати CardCreationInStocks щоб він спочатку перевіряв чи є сесія зараз. А потім шукав всі стоки по айді пользователя.
         */
        CardCreationInStocks cardStocks;

        public AddNewStockForm(UserSession userSession, ValidationService validation, DataBaseQueries queries)
        {
            InitializeComponent();
            _userSession = userSession;
            _validation = validation;
            _queries = queries;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFormClass.MoveForm(sender, e, this);
        }
        private void AddNewStockForm_Load(object sender, EventArgs e)
        {
            chooseTypeOfStock.DataSource = Enum.GetValues(typeof(TypeOfStocks));
        }

        private void closeFormButton_Click(object sender, EventArgs e) => Close();

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (confirmPasswordTextBox.Text == "")
                return;


            if (confirmPasswordTextBox.Text == passwordTextBox.Text)
            {
                infoPasswordLabel.Text = "Correct";
                infoPasswordLabel.ForeColor = Color.Green;
            }
            else {
                infoPasswordLabel.Text = "Incorrect";
                infoPasswordLabel.ForeColor = Color.Red;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "") 
                return;


            if (confirmPasswordTextBox.Text != "" && (confirmPasswordTextBox.Text == passwordTextBox.Text))
            {
                infoPasswordLabel.Text = "Correct";
                infoPasswordLabel.ForeColor = Color.Green;
            }
            else
            {
                infoPasswordLabel.Text = "Incorrect.";
                infoPasswordLabel.ForeColor = Color.Red;
            }
        }
        private void privatRadioButton_CheckedChanged(object sender, EventArgs e) => accessPrivatePanel.Visible = true;

        private void publicRadioButton_CheckedChanged(object sender, EventArgs e) => accessPrivatePanel.Visible = false;

        private void chooseTypeOfStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeOfStocks typeStock = (TypeOfStocks)chooseTypeOfStock.SelectedItem;
            importantTextPanel.Visible = true;
            switch (typeStock) {
                case TypeOfStocks.FunctionalStock:
                    infoStockLabel.Text = "This stock is better suited for tracking batches and materials.";
                    break;
                case TypeOfStocks.PhysicalStock:
                    infoStockLabel.Text = "This stock is better suited for storing goods.";
                    break;
            }
            
        }

        private void denyButton_Click(object sender, EventArgs e) => Close();

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!_validation.IsValidName(nameOfStock.Text))
            {
                MessageBox.Show("You entered an incorrect stock name.", "",MessageBoxButtons.OK);
                return;
            }

            var pas = passwordTextBox.Text;
            var pasC = confirmPasswordTextBox.Text;

            if (privatRadioButton.Checked && (!_validation.IsValidPassword(pas) || !_validation.IsValidPassword(pasC) || (pas != pasC))) {
                MessageBox.Show("Your passwords don't match each other.", "", MessageBoxButtons.OK);
                return;
            }

            var stock = _queries.AddStock(new Stock
            {
                StockName = nameOfStock.Text,
                Password = (privatRadioButton.Checked ? passwordTextBox.Text : null),
                KindOfStock = (TypeOfStocks)chooseTypeOfStock.SelectedItem,
                AccessStock = (privatRadioButton.Checked ? AccessOfStocks.Private : AccessOfStocks.Public),
                CreatorId = _userSession.CurrentUser.Id
            });

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
