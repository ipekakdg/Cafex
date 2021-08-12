using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafex
{
    public partial class FormSatis : Form
    {
        public string kullaniciAdi { get; set; }
        public string KullaniciTuru { get; set; }
        public FormSatis()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToLongDateString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            FrmMüşteriEkleme ekle = new FrmMüşteriEkleme();
            ekle.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        Context c = new Context();
        private void btnmüsterilisteleme_Click(object sender, EventArgs e)
        {
            FrmMüşteriListeleme MusteriListele = new FrmMüşteriListeleme();
            MusteriListele.ShowDialog();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Cafex; user Id=Postgres; password=i1p2e3k4");


        public void btnmüsteriekle_Click(object sender, EventArgs e)
        {
            FrmMüşteriEkleme frmMusteri = new FrmMüşteriEkleme();
            frmMusteri.ShowDialog();  
        }

        private void btnurunlistele_Click(object sender, EventArgs e)
        {

        }

        private void btnurunekleme_Click(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti1 = new NpgsqlConnection("server=localHost; port=5432; Database=Cafex; user ID=postgres; password=i1p2e3k4");
        private void btntamamlanmis_Click(object sender, EventArgs e)
        {
            String sorgu = "select * from  Urunler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnsatilanlarıgoster_Click(object sender, EventArgs e)
        {
            UrunEkleme urunekle = new UrunEkleme();
            urunekle.ShowDialog();
        }

        private void btncalısanlistele_Click(object sender, EventArgs e)
        {
            String sorgu = "select * from  Personel";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void siparisekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Insert into Siparis (MüŞteriAdı, Siparişi,Tamamlandı) values (@p7,@p8,@p9)", baglanti);
            komut2.Parameters.AddWithValue("@p7", txtAdi.Text);
            komut2.Parameters.AddWithValue("@p8", txtsiparis.Text);
            komut2.Parameters.AddWithValue("@p9", ckctamam.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sipariş Eklendi!");
        }

        private void btntunsiparisler_Click(object sender, EventArgs e)
        {
            String sorgu = "select * from  Siparis";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void guncelle_Click(object sender, EventArgs e)
        {

        }
       
        private void Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("Delete From Urun where Adı=@p1, BarkodNo=@p2, Cesidi=@p3, Boyutu=@p4, Fiyatı=@p5", baglanti);
            komut3.Parameters.AddWithValue("@p1,@p2,@p3,@p4,@5", int.Parse(txtAdi.Text));
            komut3.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Ürün Başarı ile Silindi!");
        }
    }

    internal class Musteri
    {

    }
}
