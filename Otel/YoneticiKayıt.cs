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
    }
}
