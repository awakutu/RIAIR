using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class Form1Beranda : Form
    {
        public Form1Beranda()
        {
            InitializeComponent();
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                buttonMasuk.Size = new System.Drawing.Size(172, 56);
                buttonDaftar.Size = new System.Drawing.Size(172, 56);
                buttonSyarat.Size = new System.Drawing.Size(172, 56);
            }
                
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                buttonMasuk.Size = new System.Drawing.Size(86, 28);
                buttonDaftar.Size = new System.Drawing.Size(86, 28);
                buttonSyarat.Size = new System.Drawing.Size(86, 28);
            }
                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            Form3Masuk frm3 = new Form3Masuk();
            frm3.ShowDialog();
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            Form2Daftar frm2 = new Form2Daftar();
            frm2.ShowDialog();
        }

        private void buttonSyarat_Click(object sender, EventArgs e)
        {
            Form4Syarat frm4 = new Form4Syarat();
            frm4.ShowDialog();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelAtas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
