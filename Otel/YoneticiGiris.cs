using MySql.Data.MySqlClient;
using Otel.businneslogic;
using Otel.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Otel
{
    public partial class YoneticiGiris : Form
    {
        public YoneticiGiris()
        {
            InitializeComponent();
        }
        dbBaglantı bgl = new dbBaglantı();
        private void MusteriGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            (new blyoneticigir()).yoneticigirisbil(txtkullanıcı.Text,txtgirissif.Text);
            MySqlCommand komut = new MySqlCommand("select * from tbl_yöneticigiris where kullanıcıad=@p1 and sifre=@p2", bgl.baglantıGetir());
            komut.Parameters.AddWithValue("@p1",txtkullanıcı.Text);
            komut.Parameters.AddWithValue("@p2",txtgirissif.Text);
            MySqlDataReader okunanlar = komut.ExecuteReader();
            if (okunanlar.Read())
            {
                anasayfa fr = new anasayfa();
                
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("KullanıcıAdı veya Şifreniz Yanlış");
            }
        }

        private void mskgiristc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            YoneticiKayıt k=new YoneticiKayıt();
            k.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnalt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncikis_MouseMove(object sender, MouseEventArgs e)
        {
            btncikis.BackColor = Color.Red;
        }

        private void btncikis_MouseLeave(object sender, EventArgs e)
        {
            btncikis.BackColor = Color.White;
        }

        private void btnalt_MouseMove(object sender, MouseEventArgs e)
        {
            btnalt.BackColor = Color.Blue;
        }

        private void btnalt_MouseLeave(object sender, EventArgs e)
        {
            btnalt.BackColor = Color.White;
        }
    }
}
