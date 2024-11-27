namespace nyobaprojek
{
    partial class User1
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
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Saldo = new System.Windows.Forms.TextBox();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.lvwUser = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lsvKategori = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(34, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nama";
            // 
            // tb_Nama
            // 
            this.tb_Nama.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_Nama.Location = new System.Drawing.Point(37, 112);
            this.tb_Nama.Name = "tb_Nama";
            this.tb_Nama.Size = new System.Drawing.Size(247, 20);
            this.tb_Nama.TabIndex = 16;
            this.tb_Nama.TextChanged += new System.EventHandler(this.tb_Nama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tracking Money ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(34, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Saldo";
            // 
            // tb_Saldo
            // 
            this.tb_Saldo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_Saldo.Location = new System.Drawing.Point(37, 156);
            this.tb_Saldo.Name = "tb_Saldo";
            this.tb_Saldo.Size = new System.Drawing.Size(247, 20);
            this.tb_Saldo.TabIndex = 13;
            this.tb_Saldo.TextChanged += new System.EventHandler(this.tb_Saldo_TextChanged);
            // 
            // btnSaldo
            // 
            this.btnSaldo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSaldo.Location = new System.Drawing.Point(85, 290);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(166, 46);
            this.btnSaldo.TabIndex = 20;
            this.btnSaldo.Text = "Tambah Saldo";
            this.btnSaldo.UseVisualStyleBackColor = false;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTransaksi.Location = new System.Drawing.Point(85, 220);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(166, 46);
            this.btnTransaksi.TabIndex = 19;
            this.btnTransaksi.Text = "Tambah Transaksi";
            this.btnTransaksi.UseVisualStyleBackColor = false;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnKeluar.Location = new System.Drawing.Point(85, 356);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(166, 46);
            this.btnKeluar.TabIndex = 21;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // lvwUser
            // 
            this.lvwUser.HideSelection = false;
            this.lvwUser.Location = new System.Drawing.Point(341, 61);
            this.lvwUser.Name = "lvwUser";
            this.lvwUser.Size = new System.Drawing.Size(350, 329);
            this.lvwUser.TabIndex = 22;
            this.lvwUser.UseCompatibleStateImageBehavior = false;
            this.lvwUser.SelectedIndexChanged += new System.EventHandler(this.lvwUser_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.btnKeluar);
            this.panel1.Controls.Add(this.btnTransaksi);
            this.panel1.Controls.Add(this.btnSaldo);
            this.panel1.Location = new System.Drawing.Point(-3, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 489);
            this.panel1.TabIndex = 23;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnHapus.Location = new System.Drawing.Point(697, 396);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(142, 37);
            this.btnHapus.TabIndex = 22;
            this.btnHapus.Text = "Hapus Data";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEdit.Location = new System.Drawing.Point(549, 396);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 37);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit Data";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lsvKategori
            // 
            this.lsvKategori.BackColor = System.Drawing.SystemColors.Window;
            this.lsvKategori.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lsvKategori.HideSelection = false;
            this.lsvKategori.Location = new System.Drawing.Point(653, 61);
            this.lsvKategori.Name = "lsvKategori";
            this.lsvKategori.Size = new System.Drawing.Size(186, 329);
            this.lsvKategori.TabIndex = 25;
            this.lsvKategori.UseCompatibleStateImageBehavior = false;
            // 
            // User1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 451);
            this.Controls.Add(this.lvwUser);
            this.Controls.Add(this.lsvKategori);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Nama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Saldo);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "User1";
            this.Text = "User1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Saldo;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.ListView lvwUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView lsvKategori;
    }
}