using MySql.Data.MySqlClient;
using Otel.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.DAL
{
    internal class dalyoneticibilgi

    {
        public void yoneticibilgiKaydet(yoneticibilgi a)
        {
            new MySqlCommand("insert into tbl_yöneticigiris (kullanıcıad,sifre) values ('" + a.YONETICIBILGIKUL + "','" + a.YONETICIBILGISIFRE + "')", (new dbBaglantı()).baglantıGetir()).ExecuteNonQuery();
        }
    }
}
