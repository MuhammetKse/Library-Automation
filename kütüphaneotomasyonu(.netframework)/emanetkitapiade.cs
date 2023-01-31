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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace kütüphaneotomasyonu_.netframework_
{
    public partial class emanetkitapiade : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B6GKBCE\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        public emanetkitapiade()
        {
            InitializeComponent();
        }

        private void emanetkitapiade_Load(object sender, EventArgs e)
        {
            emanetkitaplargetir();
        }
        private void emanetkitaplargetir()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar where tc like '%" + txttcara.Text + "%' ", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            baglanti.Close();
            if (txttcara.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                emanetkitaplargetir();
            }


        }

        private void txtbarkodnoara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar where barkodno like '%" + txtbarkodnoara.Text + "%' ", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            baglanti.Close();
            if (txtbarkodnoara.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                emanetkitaplargetir();
            }
        }

        private void btnteslimal_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Delete from EmanetKitaplar where tc=@tc and barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kitaplar iade edildi!");
            daset.Tables["EmanetKitaplar"].Clear();
            emanetkitaplargetir();

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
