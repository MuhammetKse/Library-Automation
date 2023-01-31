namespace kütüphaneotomasyonu_.netframework_
{
    partial class kitapekleform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.txtsayfasayısı = new System.Windows.Forms.TextBox();
            this.txtkitapadı = new System.Windows.Forms.TextBox();
            this.btnkitaptemizle = new System.Windows.Forms.Button();
            this.btnkitapekle = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.txtbarkodno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sayfa Sayısı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtyazar
            // 
            this.txtyazar.Location = new System.Drawing.Point(151, 86);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(211, 22);
            this.txtyazar.TabIndex = 4;
            // 
            // txtsayfasayısı
            // 
            this.txtsayfasayısı.Location = new System.Drawing.Point(151, 179);
            this.txtsayfasayısı.Name = "txtsayfasayısı";
            this.txtsayfasayısı.Size = new System.Drawing.Size(211, 22);
            this.txtsayfasayısı.TabIndex = 6;
            // 
            // txtkitapadı
            // 
            this.txtkitapadı.Location = new System.Drawing.Point(151, 131);
            this.txtkitapadı.Name = "txtkitapadı";
            this.txtkitapadı.Size = new System.Drawing.Size(211, 22);
            this.txtkitapadı.TabIndex = 7;
            // 
            // btnkitaptemizle
            // 
            this.btnkitaptemizle.Location = new System.Drawing.Point(287, 253);
            this.btnkitaptemizle.Name = "btnkitaptemizle";
            this.btnkitaptemizle.Size = new System.Drawing.Size(75, 37);
            this.btnkitaptemizle.TabIndex = 8;
            this.btnkitaptemizle.Text = "Temizle";
            this.btnkitaptemizle.UseVisualStyleBackColor = true;
            this.btnkitaptemizle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnkitapekle
            // 
            this.btnkitapekle.Location = new System.Drawing.Point(151, 253);
            this.btnkitapekle.Name = "btnkitapekle";
            this.btnkitapekle.Size = new System.Drawing.Size(75, 37);
            this.btnkitapekle.TabIndex = 9;
            this.btnkitapekle.Text = "Ekle";
            this.btnkitapekle.UseVisualStyleBackColor = true;
            this.btnkitapekle.Click += new System.EventHandler(this.btnkitapekle_Click);
            // 
            // btngeri
            // 
            this.btngeri.Location = new System.Drawing.Point(511, 8);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(75, 23);
            this.btngeri.TabIndex = 10;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtbarkodno
            // 
            this.txtbarkodno.Location = new System.Drawing.Point(151, 42);
            this.txtbarkodno.Name = "txtbarkodno";
            this.txtbarkodno.Size = new System.Drawing.Size(211, 22);
            this.txtbarkodno.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Barkod No";
            // 
            // kitapekleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 464);
            this.Controls.Add(this.txtbarkodno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnkitapekle);
            this.Controls.Add(this.btnkitaptemizle);
            this.Controls.Add(this.txtkitapadı);
            this.Controls.Add(this.txtsayfasayısı);
            this.Controls.Add(this.txtyazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kitapekleform";
            this.Text = "kitapekleform";
            this.Load += new System.EventHandler(this.kitapekleform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.TextBox txtsayfasayısı;
        private System.Windows.Forms.TextBox txtkitapadı;
        private System.Windows.Forms.Button btnkitaptemizle;
        private System.Windows.Forms.Button btnkitapekle;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.TextBox txtbarkodno;
        private System.Windows.Forms.Label label4;
    }
}