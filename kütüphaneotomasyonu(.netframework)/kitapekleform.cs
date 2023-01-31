using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace kütüphaneotomasyonu_.netframework_
{

    public partial class kitapekleform : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B6GKBCE\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        public kitapekleform()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbarkodno.Text = "";
            txtkitapadı.Text = "";
            txtsayfasayısı.Text = "";
            txtyazar.Text = "";

        }

        private void btnkitapekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kitapekle = new SqlCommand("insert into Kitap(barkodno,kitap,yazar,sayfa) values(@barkodno,@kitap,@yazar,@sayfa) ",baglanti);
            kitapekle.Parameters.AddWithValue("@barkodno",txtbarkodno.Text );
            kitapekle.Parameters.AddWithValue("@kitap",txtkitapadı.Text);
            kitapekle.Parameters.AddWithValue("@yazar", txtyazar.Text);
            kitapekle.Parameters.AddWithValue("@sayfa", txtsayfasayısı.Text);
            kitapekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Başarıyla Eklendi");

        }

        private void kitapekleform_Load(object sender, EventArgs e)
        {

        }
    }
}
