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
using System.Security.Cryptography;

namespace kütüphaneotomasyonu_.netframework_
{

    public partial class emanetkitaplistele : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B6GKBCE\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        public emanetkitaplistele()
        {
            InitializeComponent();
        }

        private void emanetkitaplistele_Load(object sender, EventArgs e)
        {
            emanetkitaplargetir();
            comboBox1.SelectedIndex = 0;

        }

        private void emanetkitaplargetir()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            if (comboBox1.SelectedIndex==0)
            {
                emanetkitaplargetir();
            }
            else if (comboBox1.SelectedIndex==1)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar where '"+DateTime.Now.ToShortTimeString()+"'>iadetarihi", baglanti);
                adtr.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar where '" + DateTime.Now.ToShortTimeString() + "'<=iadetarihi", baglanti);
                adtr.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                baglanti.Close();
            }
        }
    }
}
