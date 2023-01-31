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

    public partial class emanetkitapVer : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B6GKBCE\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        public emanetkitapVer()
        {
            InitializeComponent();
        }
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Sepet", baglanti);
            adtr.Fill(daset, "Sepet");
            dataGridView1.DataSource = daset.Tables["Sepet"];
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand güncelle = new SqlCommand("insert into sepet(barkodno,kitapadı,yazar,sayfasayısı,kitapsayısı,teslimtarihi,iadetarihi) values(@barkodno,@kitapadı,@yazar,@sayfasayısı,@kitapsayısı,@teslimtarihi,@iadetarihi)", baglanti);
            güncelle.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
            güncelle.Parameters.AddWithValue("@kitapadı", txtkitapad.Text);
            güncelle.Parameters.AddWithValue("@yazar", txtyaazar.Text);
            güncelle.Parameters.AddWithValue("@sayfasayısı", txtsayfasayısı.Text);
            güncelle.Parameters.AddWithValue("@kitapsayısı", txtkitapsayısı.Text);
            güncelle.Parameters.AddWithValue("@teslimtarihi", dateTimePicker1.Text);
            güncelle.Parameters.AddWithValue("@iadetarihi", dateTimePicker2.Text);
            güncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla sepete eklendi!");
            daset.Tables["Sepet"].Clear();
            sepetlistele();
            lblkitapsayı.Text = "";
            kitapsayısı();
            foreach (Control item in grpkitapbilgi.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtkitapsayısı)
                    {
                        item.Text = "";
                    }
                }
            }

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void emanetkitapVer_Load(object sender, EventArgs e)
        {
            sepetlistele();
            kitapsayısı();
        }
        private void kitapsayısı()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(kitapsayısı) from Sepet", baglanti);
            lblkitapsayı.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Uyekayit where tc like'" + txttc.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtad.Text = read["ad"].ToString();
                txtsoyad.Text = read["soyad"].ToString();
                txttelefon.Text = read["telefon"].ToString();
                txtyas.Text = read["yaş"].ToString();




            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(kitapsayısı) from EmanetKitaplar", baglanti);
            lblkayıtlıkitapsayısı.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();

            if (txttc.Text == "")
            {
                foreach (Control item in grpuyebilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        lblkayıtlıkitapsayısı.Text = "";
                    }

                }
            }
        }

        private void txtbarkodno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Kitap where barkodno like '" + txtbarkodno.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtkitapad.Text = read["kitap"].ToString();
                txtyaazar.Text = read["yazar"].ToString();
                txtsayfasayısı.Text = read["sayfa"].ToString();


            }
            baglanti.Close();
            if (txtbarkodno.Text == "")
            {
                foreach (Control item in grpkitapbilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtkitapsayısı)
                        {
                            item.Text = "";
                        }
                    }
                }
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("silinme işlemi tamamlandı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            lblkitapsayı.Text = "";
            kitapsayısı();
        }

        private void btnteslimet_Click(object sender, EventArgs e)
        {
            if (lblkitapsayı.Text != "")
            {
                
                
                    if (txttc.Text != "" && txtad.Text != "" && txtsoyad.Text != "" && txtyas.Text != "" && txttelefon.Text != "")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("insert into EmanetKitaplar(tc,ad,soyad,yas,telefon,barkodno,kitapadı,yazar,sayfasayısı,kitapsayısı,teslimtarihi,iadetarihi) values(@tc,@ad,@soyad,@yas,@telefon,@barkodno,@kitapadı,@yazar,@sayfasayısı,@kitapsayısı,@teslimtarihi,@iadetarihi) ", baglanti);
                            komut.Parameters.AddWithValue("@tc", txttc.Text);
                            komut.Parameters.AddWithValue("@ad", txtad.Text);
                            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                            komut.Parameters.AddWithValue("@yas", txtyas.Text);
                            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                            komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                            komut.Parameters.AddWithValue("@kitapadı", dataGridView1.Rows[i].Cells["kitapadı"].Value.ToString());
                            komut.Parameters.AddWithValue("@yazar", dataGridView1.Rows[i].Cells["yazar"].Value.ToString());
                            komut.Parameters.AddWithValue("@sayfasayısı", dataGridView1.Rows[i].Cells["sayfasayısı"].Value.ToString());
                            komut.Parameters.AddWithValue("@kitapsayısı", dataGridView1.Rows[i].Cells["kitapsayısı"].Value.ToString());
                            komut.Parameters.AddWithValue("@teslimtarihi", dataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("@iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());
                            komut.ExecuteNonQuery();
                           


                            baglanti.Close();




                        }
                        baglanti.Open();
                        SqlCommand komut3 = new SqlCommand("Delete From sepet", baglanti);
                        komut3.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kitaplar başarıyla emanet edildi");
                        daset.Tables["sepet"].Clear();
                        sepetlistele();
                        txttc.Text = "";
                        lblkitapsayı.Text = "";
                        kitapsayısı();
                        lblkayıtlıkitapsayısı.Text = "";
                        //komut satırları
                    }
                    else
                    {
                        MessageBox.Show("Önce üye ismi seçmelisiniz");
                    }


                



            }
            else
            {
                MessageBox.Show("Sepette Kitap Yok!");
            }




        }
    }
}
