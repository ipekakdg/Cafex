
namespace Cafex
{
    partial class İslemSec
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
            this.satisislemleri = new System.Windows.Forms.Button();
            this.stokislemleri = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // satisislemleri
            // 
            this.satisislemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.satisislemleri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satisislemleri.Location = new System.Drawing.Point(510, 269);
            this.satisislemleri.Name = "satisislemleri";
            this.satisislemleri.Size = new System.Drawing.Size(170, 77);
            this.satisislemleri.TabIndex = 0;
            this.satisislemleri.Text = "SATIŞ İŞLEMLERİ";
            this.satisislemleri.UseVisualStyleBackColor = false;
            this.satisislemleri.Click += new System.EventHandler(this.satisislemleri_Click);
            // 
            // stokislemleri
            // 
            this.stokislemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.stokislemleri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokislemleri.Location = new System.Drawing.Point(30, 269);
            this.stokislemleri.Name = "stokislemleri";
            this.stokislemleri.Size = new System.Drawing.Size(170, 77);
            this.stokislemleri.TabIndex = 1;
            this.stokislemleri.Text = "STOK İŞLEMLERİ";
            this.stokislemleri.UseVisualStyleBackColor = false;
            this.stokislemleri.Click += new System.EventHandler(this.stokislemleri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = global::Cafex.Properties.Resources.Piton_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(309, 383);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 37);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Image = global::Cafex.Properties.Resources.islemsec1;
            this.label1.Location = new System.Drawing.Point(213, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME TO CAFEX";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUser.Location = new System.Drawing.Point(257, 180);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(88, 21);
            this.LblUser.TabIndex = 4;
            this.LblUser.Text = "Personel Adı:";
            // 
            // İslemSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cafex.Properties.Resources.islemsec1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 422);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stokislemleri);
            this.Controls.Add(this.satisislemleri);
            this.Name = "İslemSec";
            this.Text = "İslemSec";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.İslemSec_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button satisislemleri;
        private System.Windows.Forms.Button stokislemleri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblUser;
    }
}