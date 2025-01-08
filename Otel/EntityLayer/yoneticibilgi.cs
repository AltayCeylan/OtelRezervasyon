using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.EntityLayer
{
    internal class yoneticibilgi
    {

        private string yoneticibilgiKul;
  
        
        private string yoneticibilgiSifre;






        public string YONETICIBILGIKUL { get { return yoneticibilgiKul; } set { yoneticibilgiKul = value; } }
        
        public string YONETICIBILGISIFRE { get { return yoneticibilgiSifre; } set { yoneticibilgiSifre = value; } }

        public yoneticibilgi(string yoneticibilgiKul,string yoneticibilgiSifre)
        {
            this.yoneticibilgiKul = yoneticibilgiKul;
           
            this.yoneticibilgiSifre = yoneticibilgiSifre;
            
        }
        public override string ToString()
        {
            return this.yoneticibilgiKul + "-" + this.yoneticibilgiSifre;
        }
    }
}
