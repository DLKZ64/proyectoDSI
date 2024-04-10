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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmLogin form1 = new FrmLogin();
            form1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarUser_Click(object sender, EventArgs e)
        {
            this.Close();

            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnRegTrab_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmRegTrab form4 = new FrmRegTrab();
            form4.Show();
        }

        private void panellog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
