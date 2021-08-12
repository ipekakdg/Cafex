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
    public partial class FrmMüşteriListeleme : Form
    {
        public FrmMüşteriListeleme()
        {
            InitializeComponent();
        }

        private void FrmMüşteriListeleme_Load(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti1 = new NpgsqlConnection("server=localHost; port=5432; Database=Cafex; user ID=postgres; password=i1p2e3k4");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sorgu = "select * from  Musteri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
