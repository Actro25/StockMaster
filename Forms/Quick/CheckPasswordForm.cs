using StockMaster.Classes.MoveForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMaster
{
    public partial class CheckPasswordForm : Form
    {
        private string _password;
        public CheckPasswordForm(string password)
        {
            InitializeComponent();
            _password = password;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFormClass.MoveForm(sender, e, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_password == textBox1.Text)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("Wrong password");
            }
        }
    }
}
