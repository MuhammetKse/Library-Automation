namespace kütüphaneotomasyonu_.netframework_
{
    partial class uyelistele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.lblcinsiyet = new System.Windows.Forms.Label();
            this.lblyas = new System.Windows.Forms.Label();
            this.lbladres = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lbltelefon = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.btngeri = new System.Windows.Forms.Button();
            this.txtara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(855, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(82, 186);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(212, 24);
            this.cmbcinsiyet.TabIndex = 36;
            this.cmbcinsiyet.SelectedIndexChanged += new System.EventHandler(this.cmbcinsiyet_SelectedIndexChanged);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(475, 6);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(75, 34);
            this.btntemizle.TabIndex = 35;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(365, 6);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(75, 34);
            this.btngüncelle.TabIndex = 34;
            this.btngüncelle.Text = "güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(82, 283);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(212, 22);
            this.txttelefon.TabIndex = 33;
            this.txttelefon.TextChanged += new System.EventHandler(this.txttelefon_TextChanged);
            // 
            // txtyas
            // 
            this.txtyas.Location = new System.Drawing.Point(82, 145);
            this.txtyas.Name = "txtyas";
            this.txtyas.Size = new System.Drawing.Size(212, 22);
            this.txtyas.TabIndex = 32;
            this.txtyas.TextChanged += new System.EventHandler(this.txtyas_TextChanged);
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(82, 233);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(212, 22);
            this.txtadres.TabIndex = 31;
            this.txtadres.TextChanged += new System.EventHandler(this.txtadres_TextChanged);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(82, 96);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(212, 22);
            this.txtsoyad.TabIndex = 30;
            this.txtsoyad.TextChanged += new System.EventHandler(this.txtsoyad_TextChanged);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(82, 49);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(212, 22);
            this.txtad.TabIndex = 29;
            this.txtad.TextChanged += new System.EventHandler(this.txtad_TextChanged);
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(82, 3);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(212, 22);
            this.txttc.TabIndex = 28;
            this.txttc.TextChanged += new System.EventHandler(this.txttc_TextChanged);
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.AutoSize = true;
            this.lblcinsiyet.Location = new System.Drawing.Point(6, 194);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(54, 16);
            this.lblcinsiyet.TabIndex = 27;
            this.lblcinsiyet.Text = "Cinsiyet";
            // 
            // lblyas
            // 
            this.lblyas.AutoSize = true;
            this.lblyas.Location = new System.Drawing.Point(22, 151);
            this.lblyas.Name = "lblyas";
            this.lblyas.Size = new System.Drawing.Size(31, 16);
            this.lblyas.TabIndex = 26;
            this.lblyas.Text = "Yaş";
            // 
            // lbladres
            // 
            this.lbladres.AutoSize = true;
            this.lbladres.Location = new System.Drawing.Point(10, 233);
            this.lbladres.Name = "lbladres";
            this.lbladres.Size = new System.Drawing.Size(43, 16);
            this.lbladres.TabIndex = 25;
            this.lbladres.Text = "Adres";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(6, 96);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(47, 16);
            this.lblsoyad.TabIndex = 24;
            this.lblsoyad.Text = "Soyad";
            // 
            // lbltelefon
            // 
            this.lbltelefon.AutoSize = true;
            this.lbltelefon.Location = new System.Drawing.Point(6, 289);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(53, 16);
            this.lbltelefon.TabIndex = 23;
            this.lbltelefon.Text = "Telefon";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(29, 52);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(24, 16);
            this.lblad.TabIndex = 22;
            this.lblad.Text = "Ad";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(28, 6);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(25, 16);
            this.lbltc.TabIndex = 21;
            this.lbltc.Text = "TC";
            // 
            // btngeri
            // 
            this.btngeri.Location = new System.Drawing.Point(783, 3);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(75, 53);
            this.btngeri.TabIndex = 37;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(3, 349);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(212, 22);
            this.txtara.TabIndex = 38;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "TC ara";
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(256, 349);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(99, 22);
            this.btnsil.TabIndex = 40;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // uyelistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 591);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.txtyas);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.lblcinsiyet);
            this.Controls.Add(this.lblyas);
            this.Controls.Add(this.lbladres);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lbltelefon);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "uyelistele";
            this.Text = "uyelistele";
            this.Load += new System.EventHandler(this.uyelistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtyas;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label lblcinsiyet;
        private System.Windows.Forms.Label lblyas;
        private System.Windows.Forms.Label lbladres;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lbltelefon;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsil;
    }
}