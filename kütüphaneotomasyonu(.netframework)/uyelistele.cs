using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphaneotomasyonu_.netframework_
{
    public partial class uyelistele : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B6GKBCE\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        public uyelistele()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txttc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();

        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from UyeKayit where tc like '"+txttc.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtad.Text = read["ad"].ToString();
                txtsoyad.Text = read["soyad"].ToString();
                txtyas.Text = read["yaş"].ToString();
                cmbcinsiyet.Text = read["cinsiyet"].ToString();
                txtadres.Text = read["adres"].ToString();
                txttelefon.Text = read["telefon"].ToString();
                

            }
            baglanti.Close();
        }

        private void uyelistele_Load(object sender, EventArgs e)
        {
            listele();
        }
        DataSet daset = new DataSet();
        private void txtara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Uyekayit"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Uyekayit where tc like'"+txtara.Text+"%'",baglanti);
            adtr.Fill(daset, "Uyekayit");
            dataGridView1.DataSource = daset.Tables["Uyekayit"];
            baglanti.Close();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Uyekayit where tc=@tc",baglanti);
            sil.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla silinmiştir.");
            daset.Tables["Uyekayit"].Clear();
            
            txttc.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtyas.Text = "";
            cmbcinsiyet.Text = "";
            txtadres.Text = "";
            txttelefon.Text = "";

        }
        private void listele()
        {
            baglanti.Open();
            SqlDataAdapter listele = new SqlDataAdapter("select *from Uyekayit",baglanti);
            listele.Fill(daset, "Uyekayit");
            dataGridView1.DataSource = daset.Tables["Uyekayit"];
            baglanti.Close();

        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand güncelle = new SqlCommand("Update Uyekayit set ad=@ad,soyad=@soyad,yaş=@yaş,cinsiyet=@cinsiyet,adres=@adres,telefon=@telefon where tc=@tc",baglanti);
            güncelle.Parameters.AddWithValue("@tc",txttc.Text);
            güncelle.Parameters.AddWithValue("@ad", txtad.Text);
            güncelle.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            güncelle.Parameters.AddWithValue("@yaş", txtyas.Text);
            güncelle.Parameters.AddWithValue("@cinsiyet", cmbcinsiyet.Text);
            güncelle.Parameters.AddWithValue("@adres", txtadres.Text);
            güncelle.Parameters.AddWithValue("@telefon", txttelefon.Text);
            güncelle.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Uyekayit"].Clear();
            listele();
            txttc.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtyas.Text = "";
            cmbcinsiyet.Text = "";
            txtadres.Text = "";
            txttelefon.Text = "";

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txttc.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtyas.Text = "";
            cmbcinsiyet.Text = "";
            txtadres.Text = "";
            txttelefon.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtyas_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbcinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtadres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
