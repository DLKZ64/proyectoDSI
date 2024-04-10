using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace proyecto_1
{
    public partial class FrmRegTrab : Form
    {
        public FrmRegTrab()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmRegTrab_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresarTrab_Click(object sender, EventArgs e)
        {
            this.Close();

            Form2 form2 = new Form2();
            form2.Show();
        }

        private void txtNombresTrab_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlIngreTrab_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
