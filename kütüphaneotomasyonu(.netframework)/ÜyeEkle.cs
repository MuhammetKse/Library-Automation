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
    public partial class ÜyeEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B6GKBCE\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        public ÜyeEkle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnuyeekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into table(tc,ad,soyad,yaş,cinsiyet,adres,email,telefon) values(@tc,@ad,@soyad,@yaş,@cinsiyet,@adres,@email,@telefon)", baglanti);
            komut.Parameters.AddWithValue("@tc",txttc.Text);
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@yaş", txtyas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cmbcinsiyet.Text);
            komut.Parameters.AddWithValue("@adres", txtadres.Text);
            komut.Parameters.AddWithValue("@email", txtemail.Text);
            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarıyla Eklendi");

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            baglanti.Close();
        
        }
        void temizle()
        {
            txttc.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtadres.Text = "";
            txtemail.Text = "";
            txttelefon.Text = "";
            txtyas.Text = "";
            cmbcinsiyet.Text = "";
            txttc.Focus();
        }
    }
}
