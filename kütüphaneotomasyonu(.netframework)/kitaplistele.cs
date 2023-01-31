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
    public partial class kitaplistele : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B6GKBCE\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        public kitaplistele()
        {
            InitializeComponent();
          

        }
        DataSet daset = new DataSet();

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand güncelle = new SqlCommand("Update Kitap set barkodno=@barkodno,kitap=@kitap,yazar=@yazar,sayfa=@sayfa where barkodno=@barkodno", baglanti);
            güncelle.Parameters.AddWithValue("barkodno", txtbarkod.Text);
            güncelle.Parameters.AddWithValue("yazar", txtyazar.Text);
            güncelle.Parameters.AddWithValue("kitap", txtkitapadı.Text);
            güncelle.Parameters.AddWithValue("sayfa", txtsayfasayısı.Text);
            güncelle.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Kitap"].Clear();
            listele();
            txtsayfasayısı.Text = "";
            txtbarkod.Text = "";
            txtbarkodnoara.Text = "";
            txtkitapadı.Text = "";
            txtyazar.Text = "";

        }
        void listele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Kitap", baglanti);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
            

        }



        private void btntemizle_Click_1(object sender, EventArgs e)
        {
            txtbarkod.Text = "";
            txtkitapadı.Text = "";
            txtyazar.Text = "";
            txtsayfasayısı.Text = "";
            listele();
           
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Kitap where barkodno=@barkodno", baglanti);
            sil.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla silinmiştir.");
            daset.Tables["Kitap"].Clear();
            listele();
        }

        private void txtbarkodnoara_TextChanged(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlDataAdapter barkodtr = new SqlDataAdapter("select *from Kitap where barkodno like'" + txtbarkodnoara.Text + "%'", baglanti);
            barkodtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
            
            daset.Tables["Kitap"].Clear();
            
        }

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Kitap"].Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Kitap where barkodno like '" + txtbarkod.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtbarkod.Text = read["barkodno"].ToString();
                txtkitapadı.Text = read["kitap"].ToString();
                txtyazar.Text = read["yazar"].ToString();
                txtsayfasayısı.Text = read["sayfa"].ToString();



            }
            baglanti.Close();
            listele();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbarkod.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            listele();
        }

       
    }
}
