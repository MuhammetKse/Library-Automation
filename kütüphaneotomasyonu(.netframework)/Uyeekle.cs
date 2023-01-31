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
    public partial class Uyeekle : Form
    {
        SqlConnection  baglanti=new SqlConnection("Data Source=DESKTOP-B6GKBCE\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        public Uyeekle()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txttc.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            cmbcinsiyet.Text = "";
            txtyas.Text = "";
            txtadres.Text = "";
            txttelefon.Text = "";

            txttc.Focus();
            
            
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
           
        }

        private void btnekle_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Uyekayit(tc,ad,soyad,yaş,cinsiyet,adres,telefon) values(@tc,@ad,@soyad,@yaş,@cinsiyet,@adres,@telefon) ", baglanti);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@yaş", txtyas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cmbcinsiyet.Text);
            komut.Parameters.AddWithValue("@adres", txtadres.Text);
            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt İşlemi Yapılmıştır.");

        }

        private void btnkayıtsil_Click(object sender, EventArgs e)
        {

        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Uyeekle_Load(object sender, EventArgs e)
        {

        }
    }
}
