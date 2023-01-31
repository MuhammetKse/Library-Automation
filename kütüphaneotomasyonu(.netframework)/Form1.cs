using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace kütüphaneotomasyonu_.netframework_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnüyeekle_Click(object sender, EventArgs e)
        {
            Uyeekle uyeekle = new Uyeekle();
            uyeekle.ShowDialog();
        }

        private void btnüyelistele_Click(object sender, EventArgs e)
        {
            uyelistele uyelistele = new uyelistele();
            uyelistele.ShowDialog();
        }

        private void btnkitapekle_Click(object sender, EventArgs e)
        {
           kitapekleform kitapekle=new kitapekleform();
            kitapekle.ShowDialog();
        }

        private void btnkitaplistele_Click(object sender, EventArgs e)
        {
            kitaplistele kitaplise=new kitaplistele();
            kitaplise.ShowDialog();
        }

        private void btnemanetkitapver_Click(object sender, EventArgs e)
        {
            emanetkitapVer emanetkitapver=new emanetkitapVer();
            emanetkitapver.ShowDialog();
        }

        private void btnemanetkitaplistele_Click(object sender, EventArgs e)
        {
            emanetkitaplistele emanetkitaplistelegetir = new emanetkitaplistele();
            emanetkitaplistelegetir.ShowDialog();
        }

        private void btnemanetkitapiade_Click(object sender, EventArgs e)
        {
            emanetkitapiade emanetkitapiade=new emanetkitapiade();
            emanetkitapiade.ShowDialog();
        }

        
    }
}
