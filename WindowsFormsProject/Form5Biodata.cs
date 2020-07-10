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
    public partial class Form5Biodata : Form
    {
        public Form5Biodata()
        {
            InitializeComponent();
        }

        private void panelFormBiodata_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximized_Click(object sender, EventArgs e)
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

        }

       
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelesai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terima Kasih, Semoga Anda Lolos Beasiswa Ya!");
            Close();
            
        }


        private void buttondataPribadi_Click(object sender, EventArgs e)
        {
            if (panelDataPribadi.Height == 54)
            {
                panelDataPribadi.Height = 188;
                this.ClientSize = new Size(667, 221);
                panelDataKeuangan.Visible = false;
                panelDataOrangTua.Visible = false;
                panelLampiran.Visible = false;
                panelSelesai.Visible = false;
            }
            else
            {
                panelDataPribadi.Height = 54;
                this.ClientSize = new Size(667, 305);
                panelDataKeuangan.Visible = true;
                panelDataOrangTua.Visible = true;
                panelLampiran.Visible = true;
                panelSelesai.Visible = true;
            }
                
        }

        private void buttonDataOrangTua_Click(object sender, EventArgs e)
        {
            if (panelDataOrangTua.Height == 54)
            {
                panelDataOrangTua.Height = 165;
                this.ClientSize = new Size(667, 198);
                panelDataKeuangan.Visible = false;
                panelDataPribadi.Visible = false;
                panelLampiran.Visible = false;
                panelSelesai.Visible = false;
            }
            else
            {
                panelDataOrangTua.Height = 54;
                this.ClientSize = new Size(667, 305);
                panelDataKeuangan.Visible = true;
                panelDataPribadi.Visible = true;
                panelLampiran.Visible = true;
                panelSelesai.Visible = true;
            }
        }


        private void buttonDataKeuangan_Click(object sender, EventArgs e)
        {
            if (panelDataKeuangan.Height == 54)
            {
                panelDataKeuangan.Height = 117;
                this.ClientSize = new Size(667, 150);
                panelDataOrangTua.Visible = false;
                panelDataPribadi.Visible = false;
                panelLampiran.Visible = false;
                panelSelesai.Visible = false;
            }
            else
            {
                panelDataKeuangan.Height = 54;
                this.ClientSize = new Size(667, 305);
                panelDataOrangTua.Visible = true;
                panelDataPribadi.Visible = true;
                panelLampiran.Visible = true;
                panelSelesai.Visible = true;
            }
        }

        private void buttonLampiran_Click(object sender, EventArgs e)
        {
            if (panelLampiran.Height == 54)
            {
                panelLampiran.Height = 161;
                this.ClientSize = new Size(667, 194);
                panelDataOrangTua.Visible = false;
                panelDataPribadi.Visible = false;
                panelDataKeuangan.Visible = false;
                panelSelesai.Visible = false;
            }
            else
            {
                panelLampiran.Height = 54;
                this.ClientSize = new Size(667, 305);
                panelDataOrangTua.Visible = true;
                panelDataPribadi.Visible = true;
                panelDataKeuangan.Visible = true;
                panelSelesai.Visible = true;
            }
        }

        private void buttonRegistrasiSelesai_Click(object sender, EventArgs e)
        {
            if (panelSelesai.Height == 54)
            {
                panelSelesai.Height = 102;
                this.ClientSize = new Size(667, 132);
                panelDataOrangTua.Visible = false;
                panelDataPribadi.Visible = false;
                panelDataKeuangan.Visible = false;
                panelLampiran.Visible = false;
            }
            else
            {
                panelSelesai.Height = 54;
                this.ClientSize = new Size(667, 305);
                panelDataOrangTua.Visible = true;
                panelDataPribadi.Visible = true;
                panelDataKeuangan.Visible = true;
                panelLampiran.Visible = true;
            }
        }

        public String tbNamaLengkapPribadi, tbTempatLahirPribadi;
        private void textBoxNamaLengkap_TextChanged(object sender, EventArgs e)
        {
            tbNamaLengkapPribadi = ((TextBox)sender).Text;
        }

        private void textBoxTempatLahir_TextChanged(object sender, EventArgs e)
        {
            tbTempatLahirPribadi = ((TextBox)sender).Text;
        }

        private String JenisKelamin;
        private void radioButtonLakiLaki_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonLakiLaki.Checked = true;
            JenisKelamin = "Laki-Laki";
        }

        private void radioButtonPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonLakiLaki.Checked = true;
            JenisKelamin = "Perempuan";
        }

        private String tbNamaLengkapAyah, tbTempatLahirAyah;

        private void textBoxNamaLengkapAyah_TextChanged(object sender, EventArgs e)
        {
            tbNamaLengkapAyah = ((TextBox)sender).Text;
        }


        private void textBoxTempatLahirAyah_TextChanged(object sender, EventArgs e)
        {
            tbTempatLahirAyah = ((TextBox)sender).Text;
        }


        private String tbNamaLengkapIbu, tbTempatLahirIbu;

        private void textBoxNamaLengkapIbu_TextChanged(object sender, EventArgs e)
        {
            tbNamaLengkapIbu = ((TextBox)sender).Text;
        }

        private void textBoxTempatLahirIbu_TextChanged(object sender, EventArgs e)
        {
            tbTempatLahirIbu = ((TextBox)sender).Text;
        }

        private String tbPenghasilan;

        private void textBoxPenghasilan_TextChanged(object sender, EventArgs e)
        {
            tbPenghasilan = ((TextBox)sender).Text;
        }

        private void buttonPilihKTM_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF(*.PDF)|*.pdf";
            openFileDialog1.ShowDialog();
        }

        private void buttonPilihKTP_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF(*.PDF)|*.pdf";
            openFileDialog1.ShowDialog();
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

        private void buttonPilihKK_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF(*.PDF)|*.pdf";
            openFileDialog1.ShowDialog();
        }


        private void buttonTrankripNilai_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF(*.PDF)|*.pdf";
            openFileDialog1.ShowDialog();
        }

        private void buttonSlipGajiKeluarga_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF(*.PDF)|*.pdf";
            openFileDialog1.ShowDialog();
        }



    }
}
