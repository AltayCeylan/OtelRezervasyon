using MySql.Data.MySqlClient;
using Otel.businneslogic;
using Otel.DAL;
using Otel.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Otel
{
    
    public partial class anasayfa : Form
    {
        private blrez _blrez = new blrez();

        public anasayfa()
        {
            InitializeComponent();
            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            bloda bll= new bloda();
            DataTable dt = bll.dataiçinveriçek();
            dataGridView1.DataSource = dt;

            blrez bl2 = new blrez();
            DataTable dt2 = bl2.dataiçinveriçek();
            dataGridView2.DataSource = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new bloda()).odaKaydet(Convert.ToInt32(txtno.Text));
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            (new bloda()).odasil(Convert.ToInt32(txtno.Text));
            this.Refresh();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtno.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int musteriId = Convert.ToInt16(textBox2.Text);
            string musteriad=txtrezad.Text;
            string musterisoyad=txtrezsoy.Text;
            long musteriTc=Convert.ToInt64(mskreztc.Text);
            int odaNo=Convert.ToInt32(txtrezoda.Text);
            string giris=dtgir.Text;
            string cikis=dtcik.Text;

            bool isUpdated=_blrez.rezguncelle(musteriId, musteriad, musterisoyad,musteriTc,odaNo, giris,cikis);
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new blrez()).rezkaydet(txtrezad.Text, txtrezsoy.Text,Convert.ToInt64( mskreztc.Text), Convert.ToInt16(txtrezoda.Text), dtgir.Text,dtcik.Text);
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnresil_Click(object sender, EventArgs e)
        {
            (new dalrez()).rezsil(Convert.ToInt64(mskreztc.Text));
            
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtrezad.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            txtrezsoy.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            mskreztc.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            txtrezoda.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            dtgir.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            dtcik.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            textBox2.Text= dataGridView2.Rows[secilen].Cells[2].Value.ToString();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            
        }
    }
}
