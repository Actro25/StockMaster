using Microsoft.EntityFrameworkCore.Storage;
using StockMaster.Data;
using StockMaster.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockMaster.Classes.CardCreation
{
    public class CardCreationInStocks
    {
        private static StockDataShowForm _formStock = new StockDataShowForm();
        private List<(Panel panel, int idPanel)> _panels = new List<(Panel panel, int idPanel)>();
        private FlowLayoutPanel _flowPanel;
        private Form1 _myForm;
        private DataBaseQueries _queries;



        private const int _baseGapsX = 14;
        private const int _baseGapsY = 15;

        private const int _basicPanelWidth = 207;
        private const int _basicPanelHeight = 124;

        public CardCreationInStocks(DataBaseQueries queries) {
            _queries = queries;
        }
        public void Create(FlowLayoutPanel flowPanel, Form1 myForm) {
            _flowPanel = flowPanel;
            _myForm = myForm;
        }
        public void ClearPanel() => _flowPanel.Controls.Cast<Control>().ToList().ForEach(c => c.Dispose()); // Перетворюємо наш контрол в зрозумілий для LINQ клас щоб пройтися по ньому та очистити всі данні з панелі

        public async void RefreshPanel() {
            _flowPanel.SuspendLayout();
            try
            {
                ClearPanel();
                var temp = await _queries.GetAllStocks();
                foreach (var item in temp) {
                    AddPanel(item);
                }
            }
            finally {
                _flowPanel.ResumeLayout();
            }
        }
        public void AddPanel(Stock stock) 
        {
            Panel tempPanel = new Panel() { 
                Size = new System.Drawing.Size(_basicPanelWidth, _basicPanelHeight),
                BackColor = ColorTranslator.FromHtml("#82CFFF"),
                Margin = new Padding(_baseGapsX, _baseGapsY, _baseGapsX, _baseGapsY),
            };

            FlowLayoutPanel innerPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(10),
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
            };
            innerPanel.Click += (s, e) => {
                if (stock.AccessStock == AccessOfStocks.Private)
                {
                    using (var checkPsw = new CheckPasswordForm(stock.Password))
                    {
                        if (checkPsw.ShowDialog() == DialogResult.OK)
                        {
                            _formStock.ShowDialog();
                        }
                    }
                }
                else
                {
                    _formStock.ShowDialog();
                }
            };

            Label nameStock = new Label()
            {
                Text = "Name: " + stock.StockName,
                AutoSize = true,
                Font = new Font(SystemFonts.DefaultFont.FontFamily, 14, FontStyle.Bold),
            };
            nameStock.Click += (s, e) => {
                if (stock.AccessStock == AccessOfStocks.Private)
                {
                    using (var checkPsw = new CheckPasswordForm(stock.Password))
                    {
                        if (checkPsw.ShowDialog() == DialogResult.OK)
                        {
                            _formStock.ShowDialog();
                        }
                    }
                }
                else {
                    _formStock.ShowDialog();
                }
            };

            Label typeOfStock = new Label()
            {
                Text = (stock.KindOfStock == TypeOfStocks.FunctionalStock) ? "TypeOfStock: FunctionalStock" : "TypeOfStock: PhysicalStock",
                AutoSize = true,
            };
            typeOfStock.Click += (s, e) => {
                if (stock.AccessStock == AccessOfStocks.Private)
                {
                    using (var checkPsw = new CheckPasswordForm(stock.Password))
                    {
                        if (checkPsw.ShowDialog() == DialogResult.OK)
                        {
                            _formStock.ShowDialog();
                        }
                    }
                }
                else
                {
                    _formStock.ShowDialog();
                }
            };

            Label accessStock = new Label() {
                Text = (stock.AccessStock == AccessOfStocks.Private) ? "Access: Private" : "Access: Public",
                AutoSize = true,
            };
            accessStock.Click += (s, e) => {
                if (stock.AccessStock == AccessOfStocks.Private)
                {
                    using (var checkPsw = new CheckPasswordForm(stock.Password))
                    {
                        if (checkPsw.ShowDialog() == DialogResult.OK)
                        {
                            _formStock.ShowDialog();
                        }
                    }
                }
                else
                {
                    _formStock.ShowDialog();
                }
            };

            Label creator = new Label()
            {
                Text = "Creator: " + stock.Creator.UserName,
                AutoSize = true,
            };
            creator.Click += (s, e) => {
                if (stock.AccessStock == AccessOfStocks.Private)
                {
                    using (var checkPsw = new CheckPasswordForm(stock.Password))
                    {
                        if (checkPsw.ShowDialog() == DialogResult.OK)
                        {
                            _formStock.ShowDialog();
                        }
                    }
                }
                else
                {
                    _formStock.ShowDialog();
                }
            };

            innerPanel.Controls.Add(nameStock);
            innerPanel.Controls.Add(typeOfStock);
            innerPanel.Controls.Add(accessStock);
            innerPanel.Controls.Add(creator);

            Button tempButton = new Button() { 
                Dock = DockStyle.Bottom,
                Text = "Видалити",
                BackColor = ColorTranslator.FromHtml("#5BB1DF"),
                FlatStyle = FlatStyle.Flat,
            };
            tempButton.FlatAppearance.BorderSize = 0;

            tempButton.Click += (s, e) =>
            {
                DialogResult dialog = MessageBox.Show("Чи ви дійсно хочете удалити цей склад?","",MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    _flowPanel.Controls.Remove(tempPanel);
                    _panels.Remove((tempPanel, stock.Id));
                    tempPanel.Dispose();
                    _queries.DeleteStockById(stock.Id);
                }
            };


            tempPanel.Controls.Add(tempButton);
            tempPanel.Controls.Add(innerPanel);
            _flowPanel.Controls.Add(tempPanel);

            _panels.Add((tempPanel, stock.Id));
        }

    }
}
