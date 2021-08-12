using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafex
{
    public partial class UrunEkleme : Form
    {
        public UrunEkleme()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UrunEkleme_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti1 = new NpgsqlConnection("server=localHost; port=5432; Database=Cafex; user ID=postgres; password=i1p2e3k4");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti1.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("intert into UrunEkle(UrunAdı,UrunAdedi) values (@p1,@p2) baglanti1 ");
            komut1.Parameters.AddWithValue("@p1",int.Parse (txtsicak.Text) );
            komut1.Parameters.AddWithValue("@p2", numericsicak.Text);
            komut1.ExecuteNonQuery();
            baglanti1.Close();
            MessageBox.Show("Sıcak Ürün Ekleme İşlemi Başarı ile gerçekleşti.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numerictatli_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnsoguk_Click(object sender, EventArgs e)
        {
            baglanti1.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("intert into UrunEkle(UrunAdı,UrunAdedi) values (@p1,@p2) baglanti1 ");
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtsoguk.Text));
            komut1.Parameters.AddWithValue("@p2", numericsoguk.Text);
            komut1.ExecuteNonQuery();
            baglanti1.Close();
            MessageBox.Show("Soğuk Ürün Ekleme İşlemi Başarı ile gerçekleşti.");
        }

        private void btntatli_Click(object sender, EventArgs e)
        {
            baglanti1.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("intert into UrunEkle(UrunAdı,UrunAdedi) values (@p1,@p2) baglanti1 ");
            komut1.Parameters.AddWithValue("@p1", int.Parse(txttatli.Text));
            komut1.Parameters.AddWithValue("@p2", numerictatli.Text);
            komut1.ExecuteNonQuery();
            baglanti1.Close();
            MessageBox.Show("Tatlı Ürün Ekleme İşlemi Başarı ile gerçekleşti.");
        }
    }
}
