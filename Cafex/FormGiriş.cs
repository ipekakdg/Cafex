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
using System.Collections.Specialized;
using System.Configuration;
using Npgsql;

namespace Cafex
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();

        }

        //bool blnfound = false;
        //NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Cafex; user ID=postgres; password=i1p2e3k4");
        //private NpgsqlConnection baglanti;



        static string connstring = String.Format("Server={0};Port={1};" +
                          "User Id={2};Password={3};Database={4}",
                    "PostgreSQL 10", "5432", "postgres", "i1p2e3k4", "Cafex");

        NpgsqlConnection baglanti = new NpgsqlConnection(connectionString: "Server=127.0.0.1;Port=5432;Database=Cafex;User Id=postgres;Password=i1p2e3k4;");
        private void Form1_Load(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                // buttongiris(this, new EventArgs());

            }
        }

        /* private void buttongiris(FormGiriş formGiriş, EventArgs eventArgs)
         {

             string sorgu = "select * from Personel";
             NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
             DataSet ds = new DataSet();
             da.Fill(ds);
             dataGridView1.DataSource = ds.Tables[0];
             throw new NotImplementedException();
         }
 */
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.girispicture = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girispicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.girispicture);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnGiris);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Location = new System.Drawing.Point(79, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 277);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Cafex.Properties.Resources.Adsız;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(178, 233);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 32);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Cafex.Properties.Resources.Piton_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(171, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 34);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // girispicture
            // 
            this.girispicture.Image = global::Cafex.Properties.Resources.MüşteriEkle2;
            this.girispicture.Location = new System.Drawing.Point(36, 70);
            this.girispicture.Name = "girispicture";
            this.girispicture.Size = new System.Drawing.Size(128, 126);
            this.girispicture.TabIndex = 6;
            this.girispicture.TabStop = false;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(195, 118);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(41, 13);
            this.Password.TabIndex = 5;
            this.Password.Text = "ŞİFRE:";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(195, 70);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(86, 13);
            this.Username.TabIndex = 4;
            this.Username.Text = "KULLANICI ADI:";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCikis.Location = new System.Drawing.Point(255, 168);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(84, 43);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGiris.Location = new System.Drawing.Point(345, 168);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(80, 43);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.giris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(287, 115);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(139, 20);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(287, 67);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(139, 20);
            this.txtAd.TabIndex = 0;
            this.txtAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormLogin
            // 
            this.BackgroundImage = global::Cafex.Properties.Resources.cafegiris;
            this.ClientSize = new System.Drawing.Size(648, 460);
            this.Controls.Add(this.panel1);
            this.Name = "FormLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormGiriş_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girispicture)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel panel1;
        private PictureBox girispicture;
        private Label Password;
        private Label Username;
        private Button btnCikis;
        //  private readonly SqlConnection baglanti1;


        //private string KullanıcıAdı;
        //private string KullaniciTuru;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (sender as TextBox);
            txt.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (sender as TextBox);
            txt.CharacterCasing = CharacterCasing.Upper;
        }

        private NpgsqlCommand cmd;
        private string sql = null;
        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void giris_Click(object sender, EventArgs e)
        {
            /*   string tur = "";
               baglanti.Open();


           string komut6 = "Select *From Personel where (KullanıcıAdı = '" + txtAd.Text + "') AND Parola = '" + txtSifre.Text + "'";
               SqlCommand islem = new SqlCommand(komut6, baglanti1);

               SqlDataReader oku = islem.ExecuteReader();
               if (oku.Read())
               {

                   baglanti.Close();
                   MessageBox.Show("Sisteme Hoşgeldiniz Sayın " + txtAd.Text, "Personel Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   FormGiriş frm = new FormGiriş();

                   frm.KullanıcıAdı = txtAd.Text;
                   baglanti.Open();
                   string kod = "Select KullaniciTuru From Personel where KullanıcıAdı='" + txtAd.Text + "'";
                   SqlCommand komut2 = new SqlCommand(kod, baglanti1);
                   SqlDataReader reading = komut2.ExecuteReader();
                   while (reading.Read())
                   {
                       tur = reading[0].ToString();
                       break;
                   }

                   baglanti.Close();
                   frm.KullaniciTuru = tur;
                   this.Hide();
                   frm.ShowDialog();
               }
               else
               {
                   MessageBox.Show("Kullanıcı Adı Veya Şifreniz Hatalı !!!", "Personel Girişi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }


            
               baglanti.Close(); */

            try
            {
                var baglanti = new NpgsqlConnection(connectionString: "Server=127.0.0.1;Port=5432;Database=Cafex;User Id=postgres;Password=i1p2e3k4;");
                baglanti.Open();
                /*NpgsqlCommand cmd = new NpgsqlCommand("Select * KullanıcıAdı= '" + txtAd.Text + "' Parola = '" + txtSifre.Text + "'", baglanti);
                cmd = new NpgsqlCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("KullanıcıAdı", txtAd);
                cmd.Parameters.AddWithValue("Parola", txtSifre);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                baglanti.Close() */

                sql = @"select * from Personel =(KullanıcıAdı,Parola)";

                cmd = new NpgsqlCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("KullanıcıAdı", txtAd.Text);
                cmd.Parameters.AddWithValue("Parola", txtSifre.Text);
                int result = (int)cmd.ExecuteNonQuery();

                baglanti.Close();
                if (result == 1)
                {
                    this.Hide();
                    new İslemSec(txtAd.Text).Show();
                }
                else
                {
                    MessageBox.Show("Lütfen Kullanıcı Adınızı/Şifrenizi kontol ediniz!", "Giriş Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA!" + ex.Message, "Bir Sorun Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            /*if (dr.Read())
            {
                blnfound = true;
                İslemSec islemSec = new İslemSec();
                islemSec.Show();
                MessageBox.Show("Hoşgeldiniz!");
                this.Hide();
   
            }

            if (blnfound == false)
            {
                MessageBox.Show("Tekrar Deneyiniz!); ", " bla bla ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            */
        }


        private void FormGiriş_Load(object sender, EventArgs e)
        {
            baglanti = new NpgsqlConnection();
        }

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        // private DataGrid dataGridView1;
        public Button btnGiris;
        public TextBox txtSifre;
        public TextBox txtAd;

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

