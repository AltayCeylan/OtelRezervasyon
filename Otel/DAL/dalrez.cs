﻿using MySql.Data.MySqlClient;
using Otel.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;

namespace Otel.DAL
{
    internal class dalrez
    {
        
            public void rezkaydet(elrez a)
            {
                new MySqlCommand("insert into MUSTERİ (MusteriAd,MusteriSoyad,MusteriTc,odaNo,Giris,Cikis,odaTipi,Fiyat) values ('" + a.MUSTERİAD + "','" + a.MUSTERİSOYAD + "','" + a.MUSTERİTC + "','" + a.ODANO + "','" + a.GIRIS + "','" + a.CIKIS +"','"+a.ODATİPİ + "','"+a.FİYAT+"')", (new dbBaglantı()).baglantıGetir()).ExecuteReader();

            }
            public void rezsil(long a)
            {
                new MySqlCommand("delete from MUSTERİ where MusteriTc=" + a, (new dbBaglantı()).baglantıGetir()).ExecuteReader();
            }
            public DataTable ver()
            {
                using (MySqlConnection bgl = new MySqlConnection("Server=172.21.54.253; Database=25_132330046; Uid=25_132330046; Pwd=!nif.ogr46CE"))
                {
                    using (MySqlCommand komut = new MySqlCommand("select MusteriAd,MusteriSoyad,MusteriTc,odaNo,Giris,Cikis,odaTipi,Fiyat from MUSTERİ", bgl))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(komut);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        private string connectionstring = "Server=172.21.54.253; Database=25_132330046; Uid=25_132330046; Pwd=!nif.ogr46CE";
        
        public bool rezguncelle(/*int musteriId,*/ string musteriad, string musterisoyad, long musteriTc, string odaNo, string giris, string cikis, string odaTipi, string fiyat)
        {
            using(MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                string query = "update MUSTERİ set MusteriAd=@ad,MusteriSoyad=@soyad,MusteriTc=@tc,odaNo=@no,Giris=@gir,Cikis=@cik,odaTipi=@tip,Fiyat=@fiyat where MusteriTc=@tc";
                MySqlCommand cmd = new MySqlCommand(query, conn);
              
                cmd.Parameters.AddWithValue("@ad", musteriad);
                cmd.Parameters.AddWithValue("@soyad", musterisoyad);
                cmd.Parameters.AddWithValue("@tc", musteriTc);
                cmd.Parameters.AddWithValue("@no", odaNo);
                cmd.Parameters.AddWithValue("@gir", giris);
                cmd.Parameters.AddWithValue("@cik", cikis);
                cmd.Parameters.AddWithValue("@tip", odaTipi);
                cmd.Parameters.AddWithValue("@fiyat", fiyat);

                conn.Open();
                int result = cmd.ExecuteNonQuery(); 
                return result > 0;
            }
        }
    }
 }


        

    



    

   
