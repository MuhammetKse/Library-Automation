using System;

namespace kütüphaneotomasyonu_.netframework_
{
    partial class kitaplistele
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
            this.btngüncelle = new System.Windows.Forms.Button();
            this.txtsayfasayısı = new System.Windows.Forms.TextBox();
            this.txtkitapadı = new System.Windows.Forms.TextBox();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.lblyas = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbarkodnoara = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(99, 194);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(75, 34);
            this.btngüncelle.TabIndex = 44;
            this.btngüncelle.Text = "güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // txtsayfasayısı
            // 
            this.txtsayfasayısı.Location = new System.Drawing.Point(99, 154);
            this.txtsayfasayısı.Name = "txtsayfasayısı";
            this.txtsayfasayısı.Size = new System.Drawing.Size(212, 22);
            this.txtsayfasayısı.TabIndex = 43;
            // 
            // txtkitapadı
            // 
            this.txtkitapadı.Location = new System.Drawing.Point(99, 105);
            this.txtkitapadı.Name = "txtkitapadı";
            this.txtkitapadı.Size = new System.Drawing.Size(212, 22);
            this.txtkitapadı.TabIndex = 42;
            // 
            // txtyazar
            // 
            this.txtyazar.Location = new System.Drawing.Point(99, 58);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(212, 22);
            this.txtyazar.TabIndex = 41;
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(99, 15);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(212, 22);
            this.txtbarkod.TabIndex = 40;
            this.txtbarkod.TextChanged += new System.EventHandler(this.txtbarkod_TextChanged);
            // 
            // lblyas
            // 
            this.lblyas.AutoSize = true;
            this.lblyas.Location = new System.Drawing.Point(2, 160);
            this.lblyas.Name = "lblyas";
            this.lblyas.Size = new System.Drawing.Size(82, 16);
            this.lblyas.TabIndex = 39;
            this.lblyas.Text = "Sayfa Sayısı";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(24, 105);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(60, 16);
            this.lblsoyad.TabIndex = 38;
            this.lblsoyad.Text = "Kitap Adı";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(39, 61);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(45, 16);
            this.lblad.TabIndex = 37;
            this.lblad.Text = "Yazar ";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(12, 15);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(72, 16);
            this.lbltc.TabIndex = 36;
            this.lbltc.Text = "Barkod No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(336, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(461, 394);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Barkod No Ara";
            // 
            // txtbarkodnoara
            // 
            this.txtbarkodnoara.Location = new System.Drawing.Point(475, 15);
            this.txtbarkodnoara.Name = "txtbarkodnoara";
            this.txtbarkodnoara.Size = new System.Drawing.Size(166, 22);
            this.txtbarkodnoara.TabIndex = 48;
            this.txtbarkodnoara.TextChanged += new System.EventHandler(this.txtbarkodnoara_TextChanged);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(672, 12);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(102, 28);
            this.btnsil.TabIndex = 49;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(236, 194);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(75, 34);
            this.btntemizle.TabIndex = 50;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click_1);
            // 
            // kitaplistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.txtbarkodnoara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.txtsayfasayısı);
            this.Controls.Add(this.txtkitapadı);
            this.Controls.Add(this.txtyazar);
            this.Controls.Add(this.txtbarkod);
            this.Controls.Add(this.lblyas);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.lbltc);
            this.Name = "kitaplistele";
            this.Text = "kitaplistele";
            this.Load += new System.EventHandler(this.kitaplistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void kitaplistele_Load(object sender, EventArgs e)
        {
            listele();
        }

        #endregion
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.TextBox txtsayfasayısı;
        private System.Windows.Forms.TextBox txtkitapadı;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.Label lblyas;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbarkodnoara;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btntemizle;
    }
}