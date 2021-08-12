using Npgsql;
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

namespace Cafex
{
    public partial class FrmMüşteriEkleme : Form
    {
        public FrmMüşteriEkleme()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti1 = new NpgsqlConnection("server=localHost; port=5432; Database=Cafex; user Id=Postgres; password=i1p2e3k4");
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti1.Open();
            string kod2 = "Select TC From Musteri where TC ='" + txtTC.Text + "'";
            SqlCommand comand = new SqlCommand(kod2);
            SqlDataReader oku = comand.ExecuteReader();

            if (oku.Read())
            {
                baglanti1.Close();
                MessageBox.Show(txtTC.Text + " TC Alınmış Lütfen Başka bir TC Giriniz !", "Müşteri Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                baglanti1.Close();
                if (txtName.Text == "" || txtSoyad.Text == "" || txtTC.Text == "" || txtMail.Text == "" ||  txtTelefon.Text == "" || txtAdres.Text == ""  )
                {
                    MessageBox.Show("Lütfen Gerekli Tüm Alanları Doldurunuz !", "Müşteri Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    baglanti1.Open();
                    String islem = "insert into Musteri (Ad,Soyad,TC,Email,Telefon,Adres) values(@a1,@a2,@a4,@a5,@a6,@a7)";
                    SqlCommand komut = new SqlCommand(islem);

                    komut.Parameters.AddWithValue("@a1", txtName.Text);
                    komut.Parameters.AddWithValue("@a2", txtSoyad.Text);
                    

                    komut.Parameters.AddWithValue("@a4", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@a5", txtTC.Text);
                    komut.Parameters.AddWithValue("@a6", txtMail.Text);
                    
                    

                    komut.ExecuteNonQuery();
                    baglanti1.Close();

                    MessageBox.Show("Kaydetme İşlemi Başarılı !", "Müşteri Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

        }

        private void FrmMüşteriEkleme_Load(object sender, EventArgs e)
        {

        }

        private void txtKadi_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSatis frmsatis = new FormSatis();
            frmsatis.ShowDialog();
        }
    }
}
