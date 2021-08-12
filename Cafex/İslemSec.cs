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
    public partial class İslemSec : Form
    {
        public İslemSec(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        private string username;

        private void İslemSec_Load(object sender, EventArgs e)
        {
            LblUser.Text = LblUser.Text + username;   
        }

        private void satisislemleri_Click(object sender, EventArgs e)
        {
            FormSatis frmsatis = new FormSatis();
            frmsatis.ShowDialog();
        }

        private void stokislemleri_Click(object sender, EventArgs e)
        {
            UrunEkleme urunekle = new UrunEkleme();
            urunekle.ShowDialog();
        }

        private void İslemSec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
