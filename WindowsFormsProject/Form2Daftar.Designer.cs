namespace WindowsFormsProject
{
    partial class Form2Daftar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEmailDftr = new System.Windows.Forms.TextBox();
            this.textBoxUsernameDftr = new System.Windows.Forms.TextBox();
            this.textBoxSandi1Dftr = new System.Windows.Forms.TextBox();
            this.textBoxSandi2Dftr = new System.Windows.Forms.TextBox();
            this.textBoxFirstNameDftr = new System.Windows.Forms.TextBox();
            this.textBoxLastNameDftr = new System.Windows.Forms.TextBox();
            this.buttonRegisterDftr = new System.Windows.Forms.Button();
            this.panelAtas = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.labelRegistrasiDftr = new System.Windows.Forms.Label();
            this.labelUsernameDftr = new System.Windows.Forms.Label();
            this.labelEmailDftr = new System.Windows.Forms.Label();
            this.labelSandiDftr = new System.Windows.Forms.Label();
            this.labelSandi2Dftr = new System.Windows.Forms.Label();
            this.labelFirstNameDftr = new System.Windows.Forms.Label();
            this.labelLastNameDftr = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelAtas.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEmailDftr
            // 
            this.textBoxEmailDftr.Location = new System.Drawing.Point(300, 110);
            this.textBoxEmailDftr.Name = "textBoxEmailDftr";
            this.textBoxEmailDftr.Size = new System.Drawing.Size(185, 20);
            this.textBoxEmailDftr.TabIndex = 0;
            this.textBoxEmailDftr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxUsernameDftr
            // 
            this.textBoxUsernameDftr.Location = new System.Drawing.Point(300, 80);
            this.textBoxUsernameDftr.Name = "textBoxUsernameDftr";
            this.textBoxUsernameDftr.Size = new System.Drawing.Size(185, 20);
            this.textBoxUsernameDftr.TabIndex = 0;
            this.textBoxUsernameDftr.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxSandi1Dftr
            // 
            this.textBoxSandi1Dftr.Location = new System.Drawing.Point(300, 140);
            this.textBoxSandi1Dftr.Name = "textBoxSandi1Dftr";
            this.textBoxSandi1Dftr.PasswordChar = '*';
            this.textBoxSandi1Dftr.Size = new System.Drawing.Size(185, 20);
            this.textBoxSandi1Dftr.TabIndex = 1;
            this.textBoxSandi1Dftr.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxSandi2Dftr
            // 
            this.textBoxSandi2Dftr.Location = new System.Drawing.Point(300, 170);
            this.textBoxSandi2Dftr.Name = "textBoxSandi2Dftr";
            this.textBoxSandi2Dftr.PasswordChar = '*';
            this.textBoxSandi2Dftr.Size = new System.Drawing.Size(185, 20);
            this.textBoxSandi2Dftr.TabIndex = 2;
            this.textBoxSandi2Dftr.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxFirstNameDftr
            // 
            this.textBoxFirstNameDftr.Location = new System.Drawing.Point(300, 200);
            this.textBoxFirstNameDftr.Name = "textBoxFirstNameDftr";
            this.textBoxFirstNameDftr.Size = new System.Drawing.Size(185, 20);
            this.textBoxFirstNameDftr.TabIndex = 3;
            this.textBoxFirstNameDftr.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBoxLastNameDftr
            // 
            this.textBoxLastNameDftr.Location = new System.Drawing.Point(300, 230);
            this.textBoxLastNameDftr.Name = "textBoxLastNameDftr";
            this.textBoxLastNameDftr.Size = new System.Drawing.Size(185, 20);
            this.textBoxLastNameDftr.TabIndex = 4;
            this.textBoxLastNameDftr.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // buttonRegisterDftr
            // 
            this.buttonRegisterDftr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(121)))), ((int)(((byte)(32)))));
            this.buttonRegisterDftr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegisterDftr.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterDftr.ForeColor = System.Drawing.Color.White;
            this.buttonRegisterDftr.Location = new System.Drawing.Point(300, 268);
            this.buttonRegisterDftr.Name = "buttonRegisterDftr";
            this.buttonRegisterDftr.Size = new System.Drawing.Size(185, 30);
            this.buttonRegisterDftr.TabIndex = 5;
            this.buttonRegisterDftr.Text = "Register";
            this.buttonRegisterDftr.UseVisualStyleBackColor = false;
            this.buttonRegisterDftr.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelAtas.Controls.Add(this.button3);
            this.panelAtas.Controls.Add(this.button2);
            this.panelAtas.Controls.Add(this.button4);
            this.panelAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtas.Location = new System.Drawing.Point(0, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(667, 33);
            this.panelAtas.TabIndex = 6;
            this.panelAtas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAtas_MouseDown);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(566, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 33);
            this.button3.TabIndex = 0;
            this.button3.Text = "_";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(600, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "□";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(634, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 33);
            this.button4.TabIndex = 0;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelRegistrasiDftr
            // 
            this.labelRegistrasiDftr.AutoSize = true;
            this.labelRegistrasiDftr.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrasiDftr.Location = new System.Drawing.Point(337, 50);
            this.labelRegistrasiDftr.Name = "labelRegistrasiDftr";
            this.labelRegistrasiDftr.Size = new System.Drawing.Size(116, 18);
            this.labelRegistrasiDftr.TabIndex = 7;
            this.labelRegistrasiDftr.Text = "REGISTRASI";
            // 
            // labelUsernameDftr
            // 
            this.labelUsernameDftr.AutoSize = true;
            this.labelUsernameDftr.Location = new System.Drawing.Point(209, 83);
            this.labelUsernameDftr.Name = "labelUsernameDftr";
            this.labelUsernameDftr.Size = new System.Drawing.Size(55, 13);
            this.labelUsernameDftr.TabIndex = 8;
            this.labelUsernameDftr.Text = "Username";
            // 
            // labelEmailDftr
            // 
            this.labelEmailDftr.AutoSize = true;
            this.labelEmailDftr.Location = new System.Drawing.Point(209, 113);
            this.labelEmailDftr.Name = "labelEmailDftr";
            this.labelEmailDftr.Size = new System.Drawing.Size(32, 13);
            this.labelEmailDftr.TabIndex = 9;
            this.labelEmailDftr.Text = "Email";
            // 
            // labelSandiDftr
            // 
            this.labelSandiDftr.AutoSize = true;
            this.labelSandiDftr.Location = new System.Drawing.Point(209, 143);
            this.labelSandiDftr.Name = "labelSandiDftr";
            this.labelSandiDftr.Size = new System.Drawing.Size(34, 13);
            this.labelSandiDftr.TabIndex = 10;
            this.labelSandiDftr.Text = "Sandi";
            // 
            // labelSandi2Dftr
            // 
            this.labelSandi2Dftr.AutoSize = true;
            this.labelSandi2Dftr.Location = new System.Drawing.Point(209, 173);
            this.labelSandi2Dftr.Name = "labelSandi2Dftr";
            this.labelSandi2Dftr.Size = new System.Drawing.Size(73, 13);
            this.labelSandi2Dftr.TabIndex = 11;
            this.labelSandi2Dftr.Text = "Sandi (Ulangi)";
            // 
            // labelFirstNameDftr
            // 
            this.labelFirstNameDftr.AutoSize = true;
            this.labelFirstNameDftr.Location = new System.Drawing.Point(209, 203);
            this.labelFirstNameDftr.Name = "labelFirstNameDftr";
            this.labelFirstNameDftr.Size = new System.Drawing.Size(57, 13);
            this.labelFirstNameDftr.TabIndex = 12;
            this.labelFirstNameDftr.Text = "First Name";
            // 
            // labelLastNameDftr
            // 
            this.labelLastNameDftr.AutoSize = true;
            this.labelLastNameDftr.Location = new System.Drawing.Point(209, 233);
            this.labelLastNameDftr.Name = "labelLastNameDftr";
            this.labelLastNameDftr.Size = new System.Drawing.Size(58, 13);
            this.labelLastNameDftr.TabIndex = 13;
            this.labelLastNameDftr.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(284, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = ":";
            // 
            // Form2Daftar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 345);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelLastNameDftr);
            this.Controls.Add(this.labelFirstNameDftr);
            this.Controls.Add(this.labelSandi2Dftr);
            this.Controls.Add(this.labelSandiDftr);
            this.Controls.Add(this.labelEmailDftr);
            this.Controls.Add(this.labelUsernameDftr);
            this.Controls.Add(this.labelRegistrasiDftr);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(this.buttonRegisterDftr);
            this.Controls.Add(this.textBoxFirstNameDftr);
            this.Controls.Add(this.textBoxLastNameDftr);
            this.Controls.Add(this.textBoxSandi1Dftr);
            this.Controls.Add(this.textBoxSandi2Dftr);
            this.Controls.Add(this.textBoxUsernameDftr);
            this.Controls.Add(this.textBoxEmailDftr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2Daftar";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2Daftar_Load);
            this.panelAtas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmailDftr;
        private System.Windows.Forms.TextBox textBoxUsernameDftr;
        private System.Windows.Forms.TextBox textBoxSandi1Dftr;
        private System.Windows.Forms.TextBox textBoxSandi2Dftr;
        private System.Windows.Forms.TextBox textBoxFirstNameDftr;
        private System.Windows.Forms.TextBox textBoxLastNameDftr;
        private System.Windows.Forms.Button buttonRegisterDftr;
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelRegistrasiDftr;
        private System.Windows.Forms.Label labelUsernameDftr;
        private System.Windows.Forms.Label labelEmailDftr;
        private System.Windows.Forms.Label labelSandiDftr;
        private System.Windows.Forms.Label labelSandi2Dftr;
        private System.Windows.Forms.Label labelFirstNameDftr;
        private System.Windows.Forms.Label labelLastNameDftr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}