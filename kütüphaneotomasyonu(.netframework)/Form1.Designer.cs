namespace kütüphaneotomasyonu_.netframework_
{
    partial class Form1
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
            this.grpüyeislem = new System.Windows.Forms.GroupBox();
            this.btnüyelistele = new System.Windows.Forms.Button();
            this.btnüyeekle = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpemanetkitap = new System.Windows.Forms.GroupBox();
            this.btnemanetkitapiade = new System.Windows.Forms.Button();
            this.btnemanetkitaplistele = new System.Windows.Forms.Button();
            this.btnemanetkitapver = new System.Windows.Forms.Button();
            this.grpKitapişlem = new System.Windows.Forms.GroupBox();
            this.btnkitaplistele = new System.Windows.Forms.Button();
            this.btnkitapekle = new System.Windows.Forms.Button();
            this.grpüyeislem.SuspendLayout();
            this.grpemanetkitap.SuspendLayout();
            this.grpKitapişlem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpüyeislem
            // 
            this.grpüyeislem.Controls.Add(this.btnüyelistele);
            this.grpüyeislem.Controls.Add(this.btnüyeekle);
            this.grpüyeislem.Location = new System.Drawing.Point(12, 12);
            this.grpüyeislem.Name = "grpüyeislem";
            this.grpüyeislem.Size = new System.Drawing.Size(370, 206);
            this.grpüyeislem.TabIndex = 0;
            this.grpüyeislem.TabStop = false;
            this.grpüyeislem.Text = "Üye İşlemleri";
            this.grpüyeislem.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnüyelistele
            // 
            this.btnüyelistele.Location = new System.Drawing.Point(47, 112);
            this.btnüyelistele.Name = "btnüyelistele";
            this.btnüyelistele.Size = new System.Drawing.Size(279, 42);
            this.btnüyelistele.TabIndex = 1;
            this.btnüyelistele.Text = "Üye Listele";
            this.btnüyelistele.UseVisualStyleBackColor = true;
            this.btnüyelistele.Click += new System.EventHandler(this.btnüyelistele_Click);
            // 
            // btnüyeekle
            // 
            this.btnüyeekle.Location = new System.Drawing.Point(47, 53);
            this.btnüyeekle.Name = "btnüyeekle";
            this.btnüyeekle.Size = new System.Drawing.Size(279, 40);
            this.btnüyeekle.TabIndex = 0;
            this.btnüyeekle.Text = "Üye Ekle";
            this.btnüyeekle.UseVisualStyleBackColor = true;
            this.btnüyeekle.Click += new System.EventHandler(this.btnüyeekle_Click);
            // 
            // grpemanetkitap
            // 
            this.grpemanetkitap.Controls.Add(this.btnemanetkitapiade);
            this.grpemanetkitap.Controls.Add(this.btnemanetkitaplistele);
            this.grpemanetkitap.Controls.Add(this.btnemanetkitapver);
            this.grpemanetkitap.Location = new System.Drawing.Point(12, 258);
            this.grpemanetkitap.Name = "grpemanetkitap";
            this.grpemanetkitap.Size = new System.Drawing.Size(751, 180);
            this.grpemanetkitap.TabIndex = 1;
            this.grpemanetkitap.TabStop = false;
            this.grpemanetkitap.Text = "Emanet Kitap İşlemleri";
            // 
            // btnemanetkitapiade
            // 
            this.btnemanetkitapiade.Location = new System.Drawing.Point(47, 142);
            this.btnemanetkitapiade.Name = "btnemanetkitapiade";
            this.btnemanetkitapiade.Size = new System.Drawing.Size(673, 32);
            this.btnemanetkitapiade.TabIndex = 2;
            this.btnemanetkitapiade.Text = "Emanet Kitap İade İşlemleri";
            this.btnemanetkitapiade.UseVisualStyleBackColor = true;
            this.btnemanetkitapiade.Click += new System.EventHandler(this.btnemanetkitapiade_Click);
            // 
            // btnemanetkitaplistele
            // 
            this.btnemanetkitaplistele.Location = new System.Drawing.Point(47, 87);
            this.btnemanetkitaplistele.Name = "btnemanetkitaplistele";
            this.btnemanetkitaplistele.Size = new System.Drawing.Size(673, 32);
            this.btnemanetkitaplistele.TabIndex = 1;
            this.btnemanetkitaplistele.Text = "Emanet Kitap Listeleme";
            this.btnemanetkitaplistele.UseVisualStyleBackColor = true;
            this.btnemanetkitaplistele.Click += new System.EventHandler(this.btnemanetkitaplistele_Click);
            // 
            // btnemanetkitapver
            // 
            this.btnemanetkitapver.Location = new System.Drawing.Point(47, 36);
            this.btnemanetkitapver.Name = "btnemanetkitapver";
            this.btnemanetkitapver.Size = new System.Drawing.Size(673, 32);
            this.btnemanetkitapver.TabIndex = 0;
            this.btnemanetkitapver.Text = "Emanet Kitap Verme ";
            this.btnemanetkitapver.UseVisualStyleBackColor = true;
            this.btnemanetkitapver.Click += new System.EventHandler(this.btnemanetkitapver_Click);
            // 
            // grpKitapişlem
            // 
            this.grpKitapişlem.Controls.Add(this.btnkitaplistele);
            this.grpKitapişlem.Controls.Add(this.btnkitapekle);
            this.grpKitapişlem.Location = new System.Drawing.Point(428, 16);
            this.grpKitapişlem.Name = "grpKitapişlem";
            this.grpKitapişlem.Size = new System.Drawing.Size(335, 202);
            this.grpKitapişlem.TabIndex = 1;
            this.grpKitapişlem.TabStop = false;
            this.grpKitapişlem.Text = "Kitap İşlemleri";
            // 
            // btnkitaplistele
            // 
            this.btnkitaplistele.Location = new System.Drawing.Point(37, 108);
            this.btnkitaplistele.Name = "btnkitaplistele";
            this.btnkitaplistele.Size = new System.Drawing.Size(267, 42);
            this.btnkitaplistele.TabIndex = 1;
            this.btnkitaplistele.Text = "Kitap Listele";
            this.btnkitaplistele.UseVisualStyleBackColor = true;
            this.btnkitaplistele.Click += new System.EventHandler(this.btnkitaplistele_Click);
            // 
            // btnkitapekle
            // 
            this.btnkitapekle.Location = new System.Drawing.Point(37, 49);
            this.btnkitapekle.Name = "btnkitapekle";
            this.btnkitapekle.Size = new System.Drawing.Size(267, 40);
            this.btnkitapekle.TabIndex = 0;
            this.btnkitapekle.Text = "Kitap Ekle";
            this.btnkitapekle.UseVisualStyleBackColor = true;
            this.btnkitapekle.Click += new System.EventHandler(this.btnkitapekle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpemanetkitap);
            this.Controls.Add(this.grpKitapişlem);
            this.Controls.Add(this.grpüyeislem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpüyeislem.ResumeLayout(false);
            this.grpemanetkitap.ResumeLayout(false);
            this.grpKitapişlem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpüyeislem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpemanetkitap;
        private System.Windows.Forms.GroupBox grpKitapişlem;
        private System.Windows.Forms.Button btnüyelistele;
        private System.Windows.Forms.Button btnüyeekle;
        private System.Windows.Forms.Button btnemanetkitapiade;
        private System.Windows.Forms.Button btnemanetkitaplistele;
        private System.Windows.Forms.Button btnemanetkitapver;
        private System.Windows.Forms.Button btnkitaplistele;
        private System.Windows.Forms.Button btnkitapekle;
    }
}

