using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.EntityLayer
{
    internal class elrez
    {
        
        public int musteriıd;
        private string musteriaAd;
        private string musteriSoyad;
        private long musteriTc;
        private string odaNo;
         private string giris;
        private string cikis;
        private string odaTipi;
        private string fiyat;





        public string MUSTERİAD { get { return musteriaAd; } set { musteriaAd = value; } }
        public string MUSTERİSOYAD { get { return musteriSoyad; } set { musteriSoyad = value; } }
        public long MUSTERİTC{ get { return musteriTc; } set { musteriTc = value; } }
        public string ODANO { get { return odaNo; } set { odaNo = value; } }
        public string GIRIS { get { return giris; } set { giris = value; } }
        public string CIKIS { get { return cikis; } set { cikis = value; } }
        public string ODATİPİ { get { return odaTipi; } set { odaTipi = value; } }
        public string FİYAT { get { return fiyat; } set { fiyat = value; } }


        public elrez(string musteriad,string musterisoyad,long musteriTc,string odaNo,string giris,string cikis,string odaTipi,string fiyat)
        {
           
            this.musteriaAd = musteriad;
            this.musteriSoyad= musterisoyad;
            this.musteriTc= musteriTc;
            this.odaNo = odaNo;
            this.giris = giris;
            this.cikis = cikis;
            this.odaTipi= odaTipi;
            this.fiyat = fiyat;

        }
        public override string ToString()
        {
            return this.musteriaAd+"-" + this.musteriSoyad+"-"+this.musteriTc+"-"+this.odaNo+"-"+this.giris+"-"+this.cikis+"-"+this.odaTipi+"-"+this.fiyat;
        }
    }
}
