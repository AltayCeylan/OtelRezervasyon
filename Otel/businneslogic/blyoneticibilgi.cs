using Otel.DAL;
using Otel.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.businneslogic
{
    internal class blyoneticibilgi
    {
        internal void yoneticibilgiKaydet(string yoneticibilgiKuL, string yoneticibilgiSifre)
        {

            (new dalyoneticibilgi()).yoneticibilgiKaydet(new yoneticibilgi(yoneticibilgiKuL, yoneticibilgiSifre));
        }
    }
}
