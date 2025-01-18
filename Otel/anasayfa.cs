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
        private Dictionary<string, List<string>> odaNumaralari;
        private bloda odaBll = new bloda();
        private DataTable odaTablosu;


        private blrez _blrez = new blrez();
        private bloda _bloda = new bloda();

        public anasayfa()
        {
            InitializeComponent();
            OdaBilgileriniYukle();
            

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            bloda bll = new bloda();
            DataTable dt = bll.dataiçinveriçek();
            dataGridView1.DataSource = dt;

            blrez bl2 = new blrez();
            DataTable dt2 = bl2.dataiçinveriçek();
            dataGridView2.DataSource = dt2;

            timer1.Start();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new bloda()).odaKaydet(Convert.ToInt32(txtno.Text));

            bloda bll = new bloda();
            DataTable dt = bll.dataiçinveriçek();
            dataGridView1.DataSource = dt;

            ;



        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            (new bloda()).odasil(Convert.ToInt32(txtno.Text));

            bloda bll = new bloda();
            DataTable dt = bll.dataiçinveriçek();
            dataGridView1.DataSource = dt;



        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtno.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtodadurum.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            //int musteriId = Convert.ToInt16(textBox2.Text);
            string musteriad = txtrezad.Text;
            string musterisoyad = txtrezsoy.Text;
            long musteriTc = Convert.ToInt64(mskreztc.Text);
            string odaNo = cmbOdaNumarasi.Text;
            string giris = dtgir.Text;
            string cikis = dtcik.Text;
            string odaTipi=cmbOdaTipi.Text;


            bool isUpdated = _blrez.rezguncelle(/*musteriId,*/ musteriad, musterisoyad, musteriTc, odaNo, giris, cikis,odaTipi);

            blrez bl2 = new blrez();
            DataTable dt2 = bl2.dataiçinveriçek();
            dataGridView2.DataSource = dt2;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new blrez()).rezkaydet(txtrezad.Text, txtrezsoy.Text, Convert.ToInt64(mskreztc.Text), cmbOdaNumarasi.Text, dtgir.Text, dtcik.Text,cmbOdaTipi.Text);

            blrez bl2 = new blrez();
            DataTable dt2 = bl2.dataiçinveriçek();
            dataGridView2.DataSource = dt2;

            if (dtcik.Value <= dtgir.Value)
            {
                MessageBox.Show("Çıkış tarihi, giriş tarihinden sonraki bir tarih olmalıdır.");
                return;
            }
            else
            {
                MessageBox.Show("Rezevasyon Oluşturuldu.");
            }



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnresil_Click(object sender, EventArgs e)
        {
            (new dalrez()).rezsil(Convert.ToInt64(mskreztc.Text));

            blrez bl2 = new blrez();
            DataTable dt2 = bl2.dataiçinveriçek();
            dataGridView2.DataSource = dt2;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtrezad.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            txtrezsoy.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            mskreztc.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            cmbOdaNumarasi.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            dtgir.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            dtcik.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();
            cmbOdaTipi.Text = dataGridView2.Rows[secilen].Cells[6].Value.ToString();



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblsaat.Text = DateTime.Now.ToLongTimeString();
            lbltarih.Text = DateTime.Now.ToLongDateString();
        }

        private void dtgir_ValueChanged(object sender, EventArgs e)
        {
            dtcik.MinDate = dtgir.Value;
        }



        private void btnkont_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncıkıs_MouseHover(object sender, EventArgs e)
        {

        }

        private void btncıkıs_MouseMove(object sender, MouseEventArgs e)
        {
            btncıkıs.BackColor = Color.Red;
        }

        private void btncıkıs_MouseLeave(object sender, EventArgs e)
        {
            btncıkıs.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnalta_MouseMove(object sender, MouseEventArgs e)
        {
            btnalta.BackColor = Color.Blue;
        }

        private void btnalta_MouseLeave(object sender, EventArgs e)
        {
            btnalta.BackColor = Color.White;
        }
          private void OdaBilgileriniYukle()
          {
              odaNumaralari = new Dictionary<string, List<string>>
              {
                  { "Tek Kişilik", new List<string> { "101", "102", "103", "104" } },
                  { "İki Kişilik", new List<string> { "201", "202", "203", "204" } }
              };


              cmbOdaTipi.Items.AddRange(new string[] { "Tek Kişilik", "İki Kişilik" });

          }


          private void cmbOdaTipi_SelectedIndexChanged_1(object sender, EventArgs e)
          {
            
             string secilenOdaTipi = cmbOdaTipi.SelectedItem?.ToString();
             if (secilenOdaTipi != null && odaNumaralari.ContainsKey(secilenOdaTipi))
             {
                 cmbOdaNumarasi.Items.Clear();
                 cmbOdaNumarasi.Items.AddRange(odaNumaralari[secilenOdaTipi].ToArray());
                 cmbOdaNumarasi.SelectedIndex = 0;
             }
        }

          private void cmbOdaNumarasi_SelectedIndexChanged(object sender, EventArgs e)
          {

          }

        private void btnodagüncelle_Click(object sender, EventArgs e)
        {
            
            string odaDurum = txtodadurum.Text;
            int odaNo = Convert.ToInt16( txtno.Text);


            bool isUpdated = _bloda.rezguncelle(odaDurum,odaNo) ;

            bloda bl1 = new bloda();
            DataTable dt1 = bl1.dataiçinveriçek();
            dataGridView1.DataSource = dt1;
        }
    }
    }



