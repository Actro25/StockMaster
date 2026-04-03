using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockMaster.classes
{
    internal class CardCreationInStocks
    {
        private List<Panel> _panels = new List<Panel>();
        private FlowLayoutPanel _flowPanel;

        private const int _baseGapsX = 14;
        private const int _baseGapsY = 15;

        private const int _basicPanelWidth = 207;
        private const int _basicPanelHeight = 124;

        public CardCreationInStocks(FlowLayoutPanel flowPanel) {
            this._flowPanel = flowPanel;
        }
        public void AddPanel() 
        {
            Panel tempPanel = new Panel();
            tempPanel.Size = new System.Drawing.Size(_basicPanelWidth, _basicPanelHeight);
            tempPanel.BackColor = ColorTranslator.FromHtml("#82CFFF");
            tempPanel.Margin = new Padding(_baseGapsX, _baseGapsY, _baseGapsX, _baseGapsY);

            Button tempButton = new Button();
            tempButton.Dock = DockStyle.Bottom;
            tempButton.Text = "Delete";
            tempButton.BackColor = ColorTranslator.FromHtml("#5BB1DF");
            tempButton.FlatStyle = FlatStyle.Flat;
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
