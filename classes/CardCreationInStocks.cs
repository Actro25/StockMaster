using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockMaster.Classes.CardCreation
{
    internal class CardCreationInStocks
    {
        private static StockDataShowForm _formStock = new StockDataShowForm();
        private List<Panel> _panels = new List<Panel>();
        private FlowLayoutPanel _flowPanel;
        private Form1 _myForm;

        private const int _baseGapsX = 14;
        private const int _baseGapsY = 15;

        private const int _basicPanelWidth = 207;
        private const int _basicPanelHeight = 124;

        public CardCreationInStocks(FlowLayoutPanel flowPanel, Form1 myForm) {
            this._flowPanel = flowPanel;
            this._myForm = myForm;
        }
        public void AddPanel() 
        {
            Panel tempPanel = new Panel() { 
                Size = new System.Drawing.Size(_basicPanelWidth, _basicPanelHeight),
                BackColor = ColorTranslator.FromHtml("#82CFFF"),
                Margin = new Padding(_baseGapsX, _baseGapsY, _baseGapsX, _baseGapsY),
            };

            tempPanel.Click += (s, e) => {
                _formStock.ShowDialog();
            };

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
                    _panels.Remove(tempPanel);
                    tempPanel.Dispose();
                }
            };

            tempPanel.Controls.Add(tempButton);

            _flowPanel.Controls.Add(tempPanel);

            _panels.Add(tempPanel);
        }

    }
}
