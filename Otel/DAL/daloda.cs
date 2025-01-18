using MySql.Data.MySqlClient;
using Otel.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel.DAL
{
    internal class daloda
    {
        public void odakaydet(eloda a)
        {
            new MySqlCommand("insert into tbl_oda (odaNo) values ('" + a.ODANO + "')", (new dbBaglantı()).baglantıGetir()).ExecuteReader();

        }
        public void odasil(int a)
        {
            new MySqlCommand("delete from tbl_oda where odaNo=" + a, (new dbBaglantı()).baglantıGetir()).ExecuteReader();
        }
        public DataTable vericek()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=172.21.54.253; Database=25_132330046; Uid=25_132330046; Pwd=!nif.ogr46CE"))
            {
                using (MySqlCommand cmd = new MySqlCommand("select odaNo,odaDurum from tbl_oda", conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }

            }
           
        }
        public bool rezguncelle(string odaDurum,int odaNo)
        {
            using (MySqlConnection conn = new MySqlConnection("Server=172.21.54.253; Database=25_132330046; Uid=25_132330046; Pwd=!nif.ogr46CE"))
            {
                string query = "update tbl_oda set odaDurum=@durum where odaNo=@no";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@durum", odaDurum);
                cmd.Parameters.AddWithValue("@no", odaNo);


                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
 


            
    
    

