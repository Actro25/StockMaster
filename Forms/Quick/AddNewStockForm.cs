using StockMaster.Classes;
using StockMaster.Classes.MoveForm;
using StockMaster.Data;
using StockMaster.Models;
using StockMaster.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StockMaster
{
    public partial class AddNewStockForm : Form
    {
        private UserSession _userSession;
        private ValidationService _validation;
        private DataBaseQueries _queries;
        private Stock _selectedStock = null;

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
        private async void AddNewStockForm_Load(object sender, EventArgs e)
        {
            chooseTypeOfStock.DataSource = Enum.GetValues(typeof(TypeOfStocks));
            var allPhysicStocks = await _queries.GetAllPhysicStocks(); ;
            foreach (var item in allPhysicStocks)
            {
                comboBox1.Items.Add(item);
            }
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
            else
            {
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
            switch (typeStock)
            {
                case TypeOfStocks.FunctionalStock:
                    infoStockLabel.Text = "This stock is better suited for tracking batches and materials.";
                    linkedStockPanel.Visible = true;
                    break;
                case TypeOfStocks.PhysicalStock:
                    infoStockLabel.Text = "This stock is better suited for storing goods.";
                    linkedStockPanel.Visible = false;
                    clearButton.PerformClick();
                    break;
            }

        }

        private void denyButton_Click(object sender, EventArgs e) => Close();

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!_validation.IsValidName(nameOfStock.Text))
            {
                MessageBox.Show("You entered an incorrect stock name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var pas = passwordTextBox.Text;
            var pasC = confirmPasswordTextBox.Text;

            if (privatRadioButton.Checked && (!_validation.IsValidPassword(pas) || !_validation.IsValidPassword(pasC) || (pas != pasC)))
            {
                MessageBox.Show("Your passwords don't match each other.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((TypeOfStocks?)chooseTypeOfStock.SelectedItem == null) {
                MessageBox.Show("Please select type of the stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var stock = _queries.AddStock(new Stock
            {
                StockName = nameOfStock.Text,
                Password = (privatRadioButton.Checked ? passwordTextBox.Text : null),
                KindOfStock = (TypeOfStocks)chooseTypeOfStock.SelectedItem,
                AccessStock = (privatRadioButton.Checked ? AccessOfStocks.Private : AccessOfStocks.Public),
                CreatorId = _userSession.CurrentUser.Id,
                LinkedPhysicStockId = (_selectedStock != null) ? _selectedStock.Id : null
            });

            DialogResult = DialogResult.OK;
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var selectedOption = (Stock)comboBox1.SelectedItem;
                if (selectedOption.AccessStock == AccessOfStocks.Private)
                {
                    using (var checkPsw = new CheckPasswordForm(selectedOption.Password))
                    {
                        if (checkPsw.ShowDialog() == DialogResult.OK)
                        {
                            _selectedStock = selectedOption;
                        }
                        else
                        {
                            _selectedStock = null;
                            comboBox1.SelectedIndex = -1;
                        }
                    }
                }
                else
                {
                    _selectedStock = selectedOption;
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _selectedStock = null;
            comboBox1.SelectedIndex = -1;
        }
    }
}
