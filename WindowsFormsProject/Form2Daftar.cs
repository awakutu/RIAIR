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
    public partial class Form2Daftar : Form
    {
        public Form2Daftar()
        {
            InitializeComponent();
        }

        private void Form2Daftar_Load(object sender, EventArgs e)
        {

        }
        private string username, email, fname, lname, sandi1, sandi2;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            username = ((TextBox)sender).Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            sandi2 = ((TextBox)sender).Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           sandi1 = ((TextBox)sender).Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           email = ((TextBox)sender).Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            lname = ((TextBox)sender).Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            fname = ((TextBox)sender).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5Biodata form5 = new Form5Biodata();

            if ((textBoxUsernameDftr.Text == "user") && (textBoxSandi2Dftr.Text == "user"))
            {
                
                MessageBox.Show("Selamat Anda Sukses Registrasi");
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            else {
                MessageBox.Show("Maaf, Anda Gagal Registrasi");
            this.DialogResult = DialogResult.OK;
            this.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            } 
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
