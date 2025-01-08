using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.DAL
{
     class dbBaglantı
    {
        public MySqlConnection baglantıGetir()
        {
            MySqlConnection baglantı = new MySqlConnection("Server=172.21.54.253; Database=25_132330046; Uid=25_132330046; Pwd=!nif.ogr46CE");
            
            baglantı.Open();
            return baglantı;


            
        }
      
    }
}


