using Otel.DAL;
using Otel.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.businneslogic
{
    internal class blrez
    {
      
        internal void rezkaydet(  string musteriAd,string musteriSoyad,long musteriTc,string odaNo,string giris,string cikis,string odaTipi)
        {

            (new dalrez()).rezkaydet(new elrez( musteriAd,musteriSoyad,musteriTc,odaNo,giris,cikis,odaTipi));
        }
        internal void rezsil(long a)
        {
            (new dalrez()).rezsil(a);
        }
      
        
        public DataTable dataiçinveriçek()
        {
            dalrez dal2 = new dalrez();
            return dal2.ver();
        }

      private dalrez _dalrez= new dalrez();
        public bool rezguncelle(/*int musteriId,*/ string musteriad, string musterisoyad, long musteriTc, string odaNo, string giris, string cikis, string odaTipi)
        {
            return _dalrez.rezguncelle(/*musteriId,*/ musteriad, musterisoyad,musteriTc,odaNo, giris, cikis,odaTipi);
        }


    }
}
