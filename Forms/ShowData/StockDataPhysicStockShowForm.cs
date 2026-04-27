using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockMaster.Classes;
using StockMaster.Classes.MoveForm;
namespace StockMaster.Forms.ShowData
{
    public partial class StockDataPhysicStockShowForm : Form
    {
        public StockDataPhysicStockShowForm()
        {
            InitializeComponent();
        }

        private void closeFormButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFormClass.MoveForm(sender,e,this);
        }
    }
}
