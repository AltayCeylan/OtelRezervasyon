using MySql.Data.MySqlClient;
using Otel.DAL;
using Otel.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel.businneslogic
{
    internal class bloda
    {

        internal void odaKaydet( int odaNo)
        {

            (new daloda()).odakaydet(new eloda( odaNo));
        }
         
        internal void odasil(int a)
        {
            (new daloda()).odasil(a);
        }
        
        public DataTable dataiçinveriçek()
        {
            daloda dal1=new daloda();
            return dal1.vericek();
        }
        private daloda _daloda = new daloda();
        public bool rezguncelle(string odaDurum,int odaNo)
        {
            return _daloda.rezguncelle(odaDurum,odaNo);
        }

    }
}
