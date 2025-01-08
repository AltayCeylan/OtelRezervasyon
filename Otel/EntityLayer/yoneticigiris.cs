using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.EntityLayer
{
    internal class yoneticigiris
    {
        private string yoneticigirisKul;
        private string yoneticigirisSifre;

        public string YONETICIGIRISKUL { get { return yoneticigirisKul; } set { yoneticigirisKul = value; } }
        public string YONETICIGIRISSIFRE { get { return yoneticigirisSifre; } set { yoneticigirisSifre = value; } }

        public yoneticigiris(string musterigirisKul, string musterigirisSifre)
        {
            this.yoneticigirisKul = yoneticigirisKul;
            this.yoneticigirisSifre =yoneticigirisSifre;
        }
        public override string ToString()
        {
            return this.yoneticigirisKul + "-" + this.yoneticigirisSifre;
        }

        
    }
    
}
