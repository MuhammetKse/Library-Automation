using System;

namespace kütüphaneotomasyonu_.netframework_
{
    partial class Uyeekle
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
            this.lbltc = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lbltelefon = new System.Windows.Forms.Label();
            this.lbladres = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblcinsiyet = new System.Windows.Forms.Label();
            this.lblyas = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(29, 15);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(25, 16);
            this.lbltc.TabIndex = 0;
            this.lbltc.Text = "TC";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(30, 61);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(24, 16);
            this.lblad.TabIndex = 1;
            this.lblad.Text = "Ad";
            // 
            // lbltelefon
            // 
            this.lbltelefon.AutoSize = true;
            this.lbltelefon.Location = new System.Drawing.Point(7, 298);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(53, 16);
            this.lbltelefon.TabIndex = 3;
            this.lbltelefon.Text = "Telefon";
            // 
            // lbladres
            // 
            this.lbladres.AutoSize = true;
            this.lbladres.Location = new System.Drawing.Point(11, 242);
            this.lbladres.Name = "lbladres";
            this.lbladres.Size = new System.Drawing.Size(43, 16);
            this.lbladres.TabIndex = 5;
            this.lbladres.Text = "Adres";
            this.lbladres.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(7, 105);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(47, 16);
            this.lblsoyad.TabIndex = 4;
            this.lblsoyad.Text = "Soyad";
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.AutoSize = true;
            this.lblcinsiyet.Location = new System.Drawing.Point(7, 203);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(54, 16);
            this.lblcinsiyet.TabIndex = 7;
            this.lblcinsiyet.Text = "Cinsiyet";
            // 
            // lblyas
            // 
            this.lblyas.AutoSize = true;
            this.lblyas.Location = new System.Drawing.Point(23, 160);
            this.lblyas.Name = "lblyas";
            this.lblyas.Size = new System.Drawing.Size(31, 16);
            this.lblyas.TabIndex = 6;
            this.lblyas.Text = "Yaş";
            this.lblyas.Click += new System.EventHandler(this.label8_Click);
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(83, 12);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(212, 22);
            this.txttc.TabIndex = 8;
            this.txttc.TextChanged += new System.EventHandler(this.txttc_TextChanged);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(83, 58);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(212, 22);
            this.txtad.TabIndex = 9;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(83, 105);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(212, 22);
            this.txtsoyad.TabIndex = 11;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(83, 242);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(212, 22);
            this.txtadres.TabIndex = 12;
            // 
            // txtyas
            // 
            this.txtyas.Location = new System.Drawing.Point(83, 154);
            this.txtyas.Name = "txtyas";
            this.txtyas.Size = new System.Drawing.Size(212, 22);
            this.txtyas.TabIndex = 13;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(83, 292);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(212, 22);
            this.txttelefon.TabIndex = 15;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(83, 349);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 34);
            this.btnekle.TabIndex = 17;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click_1);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(220, 349);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(75, 34);
            this.btntemizle.TabIndex = 18;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btngeri
            // 
            this.btngeri.Location = new System.Drawing.Point(606, -3);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(75, 53);
            this.btngeri.TabIndex = 19;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(83, 195);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(212, 24);
            this.cmbcinsiyet.TabIndex = 20;
            // 
            // Uyeekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 427);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnekle);
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
            this.Name = "Uyeekle";
            this.Text = "Uyeekle";
            this.Load += new System.EventHandler(this.Uyeekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cmbcinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lbltelefon;
        private System.Windows.Forms.Label lbladres;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblcinsiyet;
        private System.Windows.Forms.Label lblyas;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txtyas;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
    }
}