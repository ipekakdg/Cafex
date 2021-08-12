
namespace Cafex
{
    partial class FormSatis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSatis));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckctamam = new System.Windows.Forms.CheckBox();
            this.siparisekle = new System.Windows.Forms.Button();
            this.txtsiparis = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Sil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.txtfiyati = new System.Windows.Forms.TextBox();
            this.txtbarkodno = new System.Windows.Forms.TextBox();
            this.txturuncesidi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btntunsiparisler = new System.Windows.Forms.Button();
            this.btnsatilanlarıgoster = new System.Windows.Forms.Button();
            this.btncalısanlistele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siparissil = new System.Windows.Forms.Button();
            this.btnsatisyap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnmüsterilisteleme = new System.Windows.Forms.Button();
            this.btnmüsteriekle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paylaşToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelişticiHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblkisii = new System.Windows.Forms.Label();
            this.lblkisiTuru = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(702, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saat:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.ckctamam);
            this.groupBox1.Controls.Add(this.siparisekle);
            this.groupBox1.Controls.Add(this.txtsiparis);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(48, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SİPARİŞ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ckctamam
            // 
            this.ckctamam.AutoSize = true;
            this.ckctamam.Location = new System.Drawing.Point(114, 83);
            this.ckctamam.Name = "ckctamam";
            this.ckctamam.Size = new System.Drawing.Size(83, 17);
            this.ckctamam.TabIndex = 6;
            this.ckctamam.Text = "Tamamlandı";
            this.ckctamam.UseVisualStyleBackColor = true;
            // 
            // siparisekle
            // 
            this.siparisekle.Location = new System.Drawing.Point(21, 106);
            this.siparisekle.Name = "siparisekle";
            this.siparisekle.Size = new System.Drawing.Size(185, 24);
            this.siparisekle.TabIndex = 5;
            this.siparisekle.Text = "Sipariş Ekle";
            this.siparisekle.UseVisualStyleBackColor = true;
            this.siparisekle.Click += new System.EventHandler(this.siparisekle_Click);
            // 
            // txtsiparis
            // 
            this.txtsiparis.Location = new System.Drawing.Point(106, 57);
            this.txtsiparis.Name = "txtsiparis";
            this.txtsiparis.Size = new System.Drawing.Size(100, 20);
            this.txtsiparis.TabIndex = 4;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(106, 22);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 3;
            this.txtAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Siparişi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri Adı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.Sil);
            this.groupBox2.Controls.Add(this.guncelle);
            this.groupBox2.Controls.Add(this.txtfiyat);
            this.groupBox2.Controls.Add(this.txtfiyati);
            this.groupBox2.Controls.Add(this.txtbarkodno);
            this.groupBox2.Controls.Add(this.txturuncesidi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(48, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 214);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Malzeme Stok";
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(21, 178);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(75, 23);
            this.Sil.TabIndex = 12;
            this.Sil.Text = "Ürünü Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(114, 178);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(75, 23);
            this.guncelle.TabIndex = 11;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(87, 135);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtfiyat.TabIndex = 10;
            // 
            // txtfiyati
            // 
            this.txtfiyati.Location = new System.Drawing.Point(87, 96);
            this.txtfiyati.Name = "txtfiyati";
            this.txtfiyati.Size = new System.Drawing.Size(100, 20);
            this.txtfiyati.TabIndex = 9;
            // 
            // txtbarkodno
            // 
            this.txtbarkodno.Location = new System.Drawing.Point(87, 26);
            this.txtbarkodno.Name = "txtbarkodno";
            this.txtbarkodno.Size = new System.Drawing.Size(100, 20);
            this.txtbarkodno.TabIndex = 7;
            // 
            // txturuncesidi
            // 
            this.txturuncesidi.Location = new System.Drawing.Point(87, 59);
            this.txturuncesidi.Name = "txturuncesidi";
            this.txturuncesidi.Size = new System.Drawing.Size(100, 20);
            this.txturuncesidi.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Urun Adı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Fiyatı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ürün Çeşidi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Barkod No:";
            // 
            // btnUrunler
            // 
            this.btnUrunler.Location = new System.Drawing.Point(231, 5);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(177, 29);
            this.btnUrunler.TabIndex = 3;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btntamamlanmis_Click);
            // 
            // btntunsiparisler
            // 
            this.btntunsiparisler.Location = new System.Drawing.Point(231, 34);
            this.btntunsiparisler.Name = "btntunsiparisler";
            this.btntunsiparisler.Size = new System.Drawing.Size(177, 34);
            this.btntunsiparisler.TabIndex = 4;
            this.btntunsiparisler.Text = "Tüm Siparişler";
            this.btntunsiparisler.UseVisualStyleBackColor = true;
            this.btntunsiparisler.Click += new System.EventHandler(this.btntunsiparisler_Click);
            // 
            // btnsatilanlarıgoster
            // 
            this.btnsatilanlarıgoster.Location = new System.Drawing.Point(430, 5);
            this.btnsatilanlarıgoster.Name = "btnsatilanlarıgoster";
            this.btnsatilanlarıgoster.Size = new System.Drawing.Size(181, 29);
            this.btnsatilanlarıgoster.TabIndex = 7;
            this.btnsatilanlarıgoster.Text = "Ürün Ekleme";
            this.btnsatilanlarıgoster.UseVisualStyleBackColor = true;
            this.btnsatilanlarıgoster.Click += new System.EventHandler(this.btnsatilanlarıgoster_Click);
            // 
            // btncalısanlistele
            // 
            this.btncalısanlistele.Location = new System.Drawing.Point(430, 34);
            this.btncalısanlistele.Name = "btncalısanlistele";
            this.btncalısanlistele.Size = new System.Drawing.Size(181, 32);
            this.btncalısanlistele.TabIndex = 8;
            this.btncalısanlistele.Text = "Çalışan Listeleme";
            this.btncalısanlistele.UseVisualStyleBackColor = true;
            this.btncalısanlistele.Click += new System.EventHandler(this.btncalısanlistele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 271);
            this.dataGridView1.TabIndex = 9;
            // 
            // siparissil
            // 
            this.siparissil.Location = new System.Drawing.Point(284, 443);
            this.siparissil.Name = "siparissil";
            this.siparissil.Size = new System.Drawing.Size(103, 27);
            this.siparissil.TabIndex = 10;
            this.siparissil.Text = "Siparişi Sil";
            this.siparissil.UseVisualStyleBackColor = true;
            // 
            // btnsatisyap
            // 
            this.btnsatisyap.Location = new System.Drawing.Point(603, 443);
            this.btnsatisyap.Name = "btnsatisyap";
            this.btnsatisyap.Size = new System.Drawing.Size(96, 27);
            this.btnsatisyap.TabIndex = 11;
            this.btnsatisyap.Text = "Satış Yap";
            this.btnsatisyap.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnmüsterilisteleme);
            this.panel1.Controls.Add(this.btnmüsteriekle);
            this.panel1.Controls.Add(this.btncalısanlistele);
            this.panel1.Controls.Add(this.btnsatilanlarıgoster);
            this.panel1.Controls.Add(this.btntunsiparisler);
            this.panel1.Controls.Add(this.btnUrunler);
            this.panel1.Location = new System.Drawing.Point(53, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 79);
            this.panel1.TabIndex = 12;
            // 
            // btnmüsterilisteleme
            // 
            this.btnmüsterilisteleme.Location = new System.Drawing.Point(27, 34);
            this.btnmüsterilisteleme.Name = "btnmüsterilisteleme";
            this.btnmüsterilisteleme.Size = new System.Drawing.Size(180, 33);
            this.btnmüsterilisteleme.TabIndex = 10;
            this.btnmüsterilisteleme.Text = "Müşteri Listeleme";
            this.btnmüsterilisteleme.UseVisualStyleBackColor = true;
            this.btnmüsterilisteleme.Click += new System.EventHandler(this.btnmüsterilisteleme_Click);
            // 
            // btnmüsteriekle
            // 
            this.btnmüsteriekle.Location = new System.Drawing.Point(27, 5);
            this.btnmüsteriekle.Name = "btnmüsteriekle";
            this.btnmüsteriekle.Size = new System.Drawing.Size(180, 29);
            this.btnmüsteriekle.TabIndex = 9;
            this.btnmüsteriekle.Text = "Müşteri Ekle";
            this.btnmüsteriekle.UseVisualStyleBackColor = true;
            this.btnmüsteriekle.Click += new System.EventHandler(this.btnmüsteriekle_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişEkleToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.paylaşToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // siparişEkleToolStripMenuItem
            // 
            this.siparişEkleToolStripMenuItem.Name = "siparişEkleToolStripMenuItem";
            this.siparişEkleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.siparişEkleToolStripMenuItem.Text = "Sipariş Ekle";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            // 
            // paylaşToolStripMenuItem
            // 
            this.paylaşToolStripMenuItem.Name = "paylaşToolStripMenuItem";
            this.paylaşToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.paylaşToolStripMenuItem.Text = "Paylaş";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.silToolStripMenuItem,
            this.tümünüSeçToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.geriAlToolStripMenuItem.Text = "Geri Al";
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaHakkındaToolStripMenuItem,
            this.gelişticiHakkındaToolStripMenuItem});
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // firmaHakkındaToolStripMenuItem
            // 
            this.firmaHakkındaToolStripMenuItem.Name = "firmaHakkındaToolStripMenuItem";
            this.firmaHakkındaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.firmaHakkındaToolStripMenuItem.Text = "Firma Hakkında";
            // 
            // gelişticiHakkındaToolStripMenuItem
            // 
            this.gelişticiHakkındaToolStripMenuItem.Name = "gelişticiHakkındaToolStripMenuItem";
            this.gelişticiHakkındaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.gelişticiHakkındaToolStripMenuItem.Text = "Geliştici Hakkında";
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iletişimToolStripMenuItem1});
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            // 
            // iletişimToolStripMenuItem1
            // 
            this.iletişimToolStripMenuItem1.Name = "iletişimToolStripMenuItem1";
            this.iletişimToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.iletişimToolStripMenuItem1.Text = "İletişim";
            // 
            // lblkisii
            // 
            this.lblkisii.AutoSize = true;
            this.lblkisii.BackColor = System.Drawing.Color.White;
            this.lblkisii.Location = new System.Drawing.Point(570, 494);
            this.lblkisii.Name = "lblkisii";
            this.lblkisii.Size = new System.Drawing.Size(23, 13);
            this.lblkisii.TabIndex = 16;
            this.lblkisii.Text = "Kişi";
            // 
            // lblkisiTuru
            // 
            this.lblkisiTuru.AutoSize = true;
            this.lblkisiTuru.BackColor = System.Drawing.Color.White;
            this.lblkisiTuru.Location = new System.Drawing.Point(570, 521);
            this.lblkisiTuru.Name = "lblkisiTuru";
            this.lblkisiTuru.Size = new System.Drawing.Size(48, 13);
            this.lblkisiTuru.TabIndex = 17;
            this.lblkisiTuru.Text = "Kişi Türü";
            this.lblkisiTuru.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(514, 489);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox2.BackgroundImage = global::Cafex.Properties.Resources.Piton_logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(94, 500);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 39);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // FormSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Cafex.Properties.Resources.TURUNCU;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblkisiTuru);
            this.Controls.Add(this.lblkisii);
            this.Controls.Add(this.btnsatisyap);
            this.Controls.Add(this.siparissil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSatis";
            this.Text = "FormSatis";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsiparis;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.TextBox txtfiyati;
        private System.Windows.Forms.TextBox txtbarkodno;
        private System.Windows.Forms.TextBox txturuncesidi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btntunsiparisler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button siparissil;
        private System.Windows.Forms.Button btnsatisyap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paylaşToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaHakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelişticiHakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem1;
        private System.Windows.Forms.Label lblkisii;
        private System.Windows.Forms.Label lblkisiTuru;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button btnUrunler;
        public System.Windows.Forms.Button btnsatilanlarıgoster;
        public System.Windows.Forms.Button btncalısanlistele;
        public System.Windows.Forms.Button btnmüsterilisteleme;
        public System.Windows.Forms.Button btnmüsteriekle;
        private System.Windows.Forms.Button siparisekle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.CheckBox ckctamam;
    }
}