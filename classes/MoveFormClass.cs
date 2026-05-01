using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StockMaster.Classes.MoveForm
{
    internal class MoveFormClass
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int WParam, int lParam);

        public static void MoveForm(object sender, MouseEventArgs e, Form form)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(form.Handle, 0x112, 0xf012, 0);
            }
        }
    }
}
