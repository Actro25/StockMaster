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
    public partial class StockDataShowForm : Form
    {

        public StockDataShowForm()
        {
            InitializeComponent();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFormClass.MoveForm(sender, e, this);
        }
        private void closeFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
