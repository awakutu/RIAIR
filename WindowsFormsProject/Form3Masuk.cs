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
    public partial class Form3Masuk : Form
    {
       
        public Form3Masuk()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegisterDftr_Click(object sender, EventArgs e)
        {
            if ((textBoxUsernameMasuk.Text =="user") && (textBoxSandiMasuk.Text == "oke"))
            {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
            Form5Biodata frm5 = new Form5Biodata();
            frm5.ShowDialog();
            }
            else if((textBoxUsernameMasuk.Text=="") &&  (textBoxSandiMasuk.Text == ""))
            {
                MessageBox.Show("Silahkan Masukkan Username dan Password!");
            }
            else
            {
                MessageBox.Show("Username dan Password Tidak Sesuai!");
            }

            
            
            
        }

        private void Form3Masuk_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panellupa.Visible = true;
        }

        private void panelLupaPassword_Paint(object sender, PaintEventArgs e)
        {
           // panellogin.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
            Form1Beranda frm1 = new Form1Beranda();
            frm1.ShowDialog();
        }

        private void panellogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            if ((textBoxUsernameMasuk.Text == "user") && (textBoxSandiMasuk.Text == "user"))
            {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                Form5Biodata frm5 = new Form5Biodata();
                frm5.ShowDialog();
            }
            else if ((textBoxUsernameMasuk.Text == "") && (textBoxSandiMasuk.Text == ""))
            {
                MessageBox.Show("Silahkan Masukkan Username dan Password!");
            }
            else
            {
                MessageBox.Show("Username dan Password Tidak Sesuai!");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panellupa.Visible = false;
            panellogin.Visible = true;
            
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

        private void textBoxSandiLupaPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsernameLupaPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
