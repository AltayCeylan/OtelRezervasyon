using Otel.businneslogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel
{
    public partial class YoneticiKayıt : Form
    {
        public YoneticiKayıt()
        {
            InitializeComponent();
        }

        private void MusteriKayıt_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new blyoneticibilgi()).yoneticibilgiKaydet( txtkula.Text,txtbilsi.Text);
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnalta_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncıkıs_MouseMove(object sender, MouseEventArgs e)
        {
            btncıkıs.BackColor = Color.Red;
        }

        private void btncıkıs_MouseLeave(object sender, EventArgs e)
        {
            btncıkıs.BackColor= Color.White;
        }

        private void btnalta_MouseMove(object sender, MouseEventArgs e)
        {
            btnalta.BackColor = Color.Blue;
        }

        private void btnalta_MouseLeave(object sender, EventArgs e)
        {
            btnalta.BackColor= Color.White;
        }
    }
}
