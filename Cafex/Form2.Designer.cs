
namespace Cafex
{
    partial class Form2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtsiparis = new System.Windows.Forms.TextBox();
            this.txturuncesidi = new System.Windows.Forms.TextBox();
            this.txtbarkodno = new System.Windows.Forms.TextBox();
            this.txtfiyati = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.btntamamlanmis = new System.Windows.Forms.Button();
            this.btntunsiparisler = new System.Windows.Forms.Button();
            this.btnurunekleme = new System.Windows.Forms.Button();
            this.btnurunlistele = new System.Windows.Forms.Button();
            this.btnsatilanlarıgoster = new System.Windows.Forms.Button();
            this.btnsiparisiptal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsatisyap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saat:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txtsiparis);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SİPARİŞ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.txtfiyat);
            this.groupBox2.Controls.Add(this.txtfiyati);
            this.groupBox2.Controls.Add(this.txtbarkodno);
            this.groupBox2.Controls.Add(this.txturuncesidi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(35, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 214);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Malzeme Stok";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Siparişi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tamamlandı";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ürün Çeşidi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Boyutu: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Fiyatı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Toplam Fiyat:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(106, 22);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 3;
            this.txtAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtsiparis
            // 
            this.txtsiparis.Location = new System.Drawing.Point(106, 57);
            this.txtsiparis.Name = "txtsiparis";
            this.txtsiparis.Size = new System.Drawing.Size(100, 20);
            this.txtsiparis.TabIndex = 4;
            // 
            // txturuncesidi
            // 
            this.txturuncesidi.Location = new System.Drawing.Point(87, 59);
            this.txturuncesidi.Name = "txturuncesidi";
            this.txturuncesidi.Size = new System.Drawing.Size(100, 20);
            this.txturuncesidi.TabIndex = 6;
            // 
            // txtbarkodno
            // 
            this.txtbarkodno.Location = new System.Drawing.Point(87, 26);
            this.txtbarkodno.Name = "txtbarkodno";
            this.txtbarkodno.Size = new System.Drawing.Size(100, 20);
            this.txtbarkodno.TabIndex = 7;
            // 
            // txtfiyati
            // 
            this.txtfiyati.Location = new System.Drawing.Point(87, 132);
            this.txtfiyati.Name = "txtfiyati";
            this.txtfiyati.Size = new System.Drawing.Size(100, 20);
            this.txtfiyati.TabIndex = 9;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(87, 165);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtfiyat.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(106, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Yes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(149, 97);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(40, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "No";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(87, 98);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(43, 17);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Tall";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(136, 98);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(51, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Small";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // btntamamlanmis
            // 
            this.btntamamlanmis.Location = new System.Drawing.Point(23, 4);
            this.btntamamlanmis.Name = "btntamamlanmis";
            this.btntamamlanmis.Size = new System.Drawing.Size(145, 34);
            this.btntamamlanmis.TabIndex = 3;
            this.btntamamlanmis.Text = "Tamamlanmamış Siparişler";
            this.btntamamlanmis.UseVisualStyleBackColor = true;
            // 
            // btntunsiparisler
            // 
            this.btntunsiparisler.Location = new System.Drawing.Point(23, 33);
            this.btntunsiparisler.Name = "btntunsiparisler";
            this.btntunsiparisler.Size = new System.Drawing.Size(145, 34);
            this.btntunsiparisler.TabIndex = 4;
            this.btntunsiparisler.Text = "Tüm Siparişler";
            this.btntunsiparisler.UseVisualStyleBackColor = true;
            // 
            // btnurunekleme
            // 
            this.btnurunekleme.Location = new System.Drawing.Point(172, 4);
            this.btnurunekleme.Name = "btnurunekleme";
            this.btnurunekleme.Size = new System.Drawing.Size(141, 34);
            this.btnurunekleme.TabIndex = 5;
            this.btnurunekleme.Text = "Ürün Ekleme";
            this.btnurunekleme.UseVisualStyleBackColor = true;
            // 
            // btnurunlistele
            // 
            this.btnurunlistele.Location = new System.Drawing.Point(172, 33);
            this.btnurunlistele.Name = "btnurunlistele";
            this.btnurunlistele.Size = new System.Drawing.Size(141, 34);
            this.btnurunlistele.TabIndex = 6;
            this.btnurunlistele.Text = "Ürün Lİstesi";
            this.btnurunlistele.UseVisualStyleBackColor = true;
            // 
            // btnsatilanlarıgoster
            // 
            this.btnsatilanlarıgoster.Location = new System.Drawing.Point(320, 4);
            this.btnsatilanlarıgoster.Name = "btnsatilanlarıgoster";
            this.btnsatilanlarıgoster.Size = new System.Drawing.Size(142, 34);
            this.btnsatilanlarıgoster.TabIndex = 7;
            this.btnsatilanlarıgoster.Text = "Satılanları Göster";
            this.btnsatilanlarıgoster.UseVisualStyleBackColor = true;
            // 
            // btnsiparisiptal
            // 
            this.btnsiparisiptal.Location = new System.Drawing.Point(320, 33);
            this.btnsiparisiptal.Name = "btnsiparisiptal";
            this.btnsiparisiptal.Size = new System.Drawing.Size(142, 33);
            this.btnsiparisiptal.TabIndex = 8;
            this.btnsiparisiptal.Text = "Sipariş İptal";
            this.btnsiparisiptal.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(269, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 271);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(269, 397);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(103, 27);
            this.btnekle.TabIndex = 10;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            // 
            // btnsatisyap
            // 
            this.btnsatisyap.Location = new System.Drawing.Point(588, 397);
            this.btnsatisyap.Name = "btnsatisyap";
            this.btnsatisyap.Size = new System.Drawing.Size(96, 27);
            this.btnsatisyap.TabIndex = 11;
            this.btnsatisyap.Text = "Satış Yap";
            this.btnsatisyap.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsiparisiptal);
            this.panel1.Controls.Add(this.btnsatilanlarıgoster);
            this.panel1.Controls.Add(this.btnurunlistele);
            this.panel1.Controls.Add(this.btnurunekleme);
            this.panel1.Controls.Add(this.btntunsiparisler);
            this.panel1.Controls.Add(this.btntamamlanmis);
            this.panel1.Location = new System.Drawing.Point(130, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 70);
            this.panel1.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.btnsatisyap);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsiparis;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.TextBox txtfiyati;
        private System.Windows.Forms.TextBox txtbarkodno;
        private System.Windows.Forms.TextBox txturuncesidi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button btntamamlanmis;
        private System.Windows.Forms.Button btntunsiparisler;
        private System.Windows.Forms.Button btnurunekleme;
        private System.Windows.Forms.Button btnurunlistele;
        private System.Windows.Forms.Button btnsatilanlarıgoster;
        private System.Windows.Forms.Button btnsiparisiptal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsatisyap;
        private System.Windows.Forms.Panel panel1;
    }
}