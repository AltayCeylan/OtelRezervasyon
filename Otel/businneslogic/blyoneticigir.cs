using Otel.DAL;
using Otel.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.businneslogic
{
    internal class blyoneticigir
    {
        internal void yoneticigirisbil(string yoneticigirisKul,string yoneticigirisSifre)
        {

            (new dalyoneticigir()).yoneticigiris(new yoneticigiris(yoneticigirisKul,yoneticigirisSifre));
            
        }
    }
}
