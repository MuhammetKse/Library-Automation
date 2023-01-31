namespace kütüphaneotomasyonu_.netframework_
{
    partial class emanetkitapiade
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
            this.btnteslimal = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.txttcara = new System.Windows.Forms.TextBox();
            this.txtbarkodnoara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnteslimal
            // 
            this.btnteslimal.Location = new System.Drawing.Point(642, 46);
            this.btnteslimal.Name = "btnteslimal";
            this.btnteslimal.Size = new System.Drawing.Size(87, 37);
            this.btnteslimal.TabIndex = 1;
            this.btnteslimal.Text = "Teslim Al";
            this.btnteslimal.UseVisualStyleBackColor = true;
            this.btnteslimal.Click += new System.EventHandler(this.btnteslimal_Click);
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(774, 46);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(75, 37);
            this.btniptal.TabIndex = 2;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // txttcara
            // 
            this.txttcara.Location = new System.Drawing.Point(94, 49);
            this.txttcara.Name = "txttcara";
            this.txttcara.Size = new System.Drawing.Size(100, 22);
            this.txttcara.TabIndex = 3;
            this.txttcara.TextChanged += new System.EventHandler(this.txttcara_TextChanged);
            // 
            // txtbarkodnoara
            // 
            this.txtbarkodnoara.Location = new System.Drawing.Point(314, 46);
            this.txtbarkodnoara.Name = "txtbarkodnoara";
            this.txtbarkodnoara.Size = new System.Drawing.Size(100, 22);
            this.txtbarkodnoara.TabIndex = 4;
            this.txtbarkodnoara.TextChanged += new System.EventHandler(this.txtbarkodnoara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Barkod No Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tc Ara";
            // 
            // emanetkitapiade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbarkodnoara);
            this.Controls.Add(this.txttcara);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnteslimal);
            this.Controls.Add(this.dataGridView1);
            this.Name = "emanetkitapiade";
            this.Text = "Emanet Kitap İade";
            this.Load += new System.EventHandler(this.emanetkitapiade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnteslimal;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.TextBox txttcara;
        private System.Windows.Forms.TextBox txtbarkodnoara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}