using StockMaster.Classes.MoveForm;
using StockMaster.Data;
using StockMaster.Models;
using StockMaster.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StockMaster.Forms.Quick
{
    public partial class StockSettingsForm : Form
    {
        private StockStorage _currentStock;
        private DataBaseQueries _queries;
        private ValidationService _validation;
        private Stock _selectedStock = null;
        private bool _isInitializingComboBox = true;
        public StockSettingsForm(StockStorage currentStock, DataBaseQueries queries, ValidationService validation)
        {
            InitializeComponent();
            _currentStock = currentStock;
            _queries = queries;
            _validation = validation;
        }

        private async void StockSettingsForm_Load(object sender, EventArgs e)
        {
            nameOfStock.Text = _currentStock.Current.StockName;
            chooseTypeOfStock.DataSource = Enum.GetValues(typeof(TypeOfStocks));
            chooseTypeOfStock.SelectedItem = _currentStock.Current.KindOfStock;
            if (_currentStock.Current.AccessStock == AccessOfStocks.Private)
            {
                privatRadioButton.Checked = true;
                passwordTextBox.Text = _currentStock.Current.Password;
                confirmPasswordTextBox.Text = _currentStock.Current.Password;
            }
            else
            {
                publicRadioButton.Checked = true;
            }
            var allPhysicStocks = await _queries.GetAllPhysicStocks(); ;
            foreach (var item in allPhysicStocks)
            {
                comboBox1.Items.Add(item);
                if (_currentStock.Current.LinkedPhysicStockId == item.Id) {
                    comboBox1.SelectedItem = item;
                }
            }
            _isInitializingComboBox = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void denyButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFormClass.MoveForm(sender, e, this);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!_validation.IsValidName(nameOfStock.Text))
            {
                MessageBox.Show("You entered an incorrect stock name.", "", MessageBoxButtons.OK);
                return;
            }

            var pas = passwordTextBox.Text;
            var pasC = confirmPasswordTextBox.Text;

            if (privatRadioButton.Checked && (!_validation.IsValidPassword(pas) || !_validation.IsValidPassword(pasC) || (pas != pasC)))
            {
                MessageBox.Show("Your passwords don't match each other.", "", MessageBoxButtons.OK);
                return;
            }

            _queries.UpdateStock(new Stock
            {
                Id = _currentStock.Current.Id,
                StockName = nameOfStock.Text,
                Password = (privatRadioButton.Checked ? passwordTextBox.Text : null),
                KindOfStock = (TypeOfStocks)chooseTypeOfStock.SelectedItem,
                AccessStock = (privatRadioButton.Checked ? AccessOfStocks.Private : AccessOfStocks.Public),
                CreatorId = _currentStock.Current.CreatorId,
                LinkedPhysicStockId = (_selectedStock != null) ? _selectedStock.Id : null
            });

            _currentStock.Current = null;

            DialogResult = DialogResult.OK;
            Close();
        }
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            _selectedStock = null;
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitializingComboBox)
                return;
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
    }
}
