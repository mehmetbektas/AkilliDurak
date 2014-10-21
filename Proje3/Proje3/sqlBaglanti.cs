using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Proje3
{
    public class sqlBaglanti
    {
        public SqlConnection baglan()//baglantı kuruluyor.
        {
            SqlConnection baglanti = new SqlConnection("Data Source = lenovo\\SQLEXPRESS; Initial Catalog = AkilliDurak; Integrated Security = True");
            baglanti.Open();
            return (baglanti);
        }

        public int cmd(string sqlkomut)//gönderilen sql cümlesine(komutuna) göre işlem yapar.
        {                              //önce baglantiyi yapar sonra sorgu oluşturur parametre olarak aldığı
            SqlConnection baglan = this.baglan();//sqlkomut değişkeni sayesinde...
            SqlCommand sorgu = new SqlCommand(sqlkomut, baglan);
            int sonuc = 0;

            try//eğer komut çalıştırıldıysa try kısmı çalışacak ve hata mesajı çıkmayacak..
            {
                sonuc = sorgu.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message + "(" + sqlkomut + ")");
            }
            sorgu.Dispose();
            baglan.Close();
            baglan.Dispose();
            return (sonuc);

        }
        public DataTable dtGetir(string sqlkomut)//Datatable dönrürür geriye. Komuta göre dt içinde tuttuğu tablodan istenen değerin çağrılmasına olanak sağlar.
        {
            SqlConnection baglan = this.baglan();
            SqlDataAdapter da = new SqlDataAdapter(sqlkomut, baglan);
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message + "(" + sqlkomut + ")");
            }
            da.Dispose();//Data adapter nesnesini temizler.
            baglan.Close();//Baglantiyi kapatır.
            baglan.Dispose();//Baglantiyi temizler.
            return dt;
        }
        public DataSet dsGetir(string sqlkomut)//Dataset dönrürür geriye. Komuta göre ds içinde tuttuğu tablodan istenen değerin çağrılmasına olanak sağlar.
        {
            SqlConnection baglan = this.baglan();
            SqlDataAdapter da = new SqlDataAdapter(sqlkomut, baglan);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message + "(" + sqlkomut + ")");//hata mesajı + sqlkomutu ile birlikte...
            }
            da.Dispose();
            baglan.Close();
            baglan.Dispose();
            return ds;//Geriye dataset tipinden bir nesne döndürür.
        }
        public DataRow drGetir(string sqlkomut)//Datatable'ı kullanarak, parametre olarak aldığı sqlkomut değişkeninde saklanan
        {                                //sql komutuna göre veri tabanından bir satır çeker.
            DataTable datab = dtGetir(sqlkomut);
            if (datab.Rows.Count == 0) return null;
            return datab.Rows[0];//Geriye datarow türünden nesne döndürür.
        }
        public string dataCellGetir(string sqlkomut)//Datatable'ı kullanarak, parametre olarak aldığı sqlkomut değişkeninde saklanan
        {                               //sql komutuna göre veri tabanından bir hücre çeker.
            DataTable datab = dtGetir(sqlkomut);
            if (datab.Rows.Count == 0) return null;
            return datab.Rows[0][0].ToString();//Geriye hücredeki değeri döndüreceği için string tipinde bir değer döndürür.
        }
        public SqlDataReader datareader(string sqlkomut)
        {
            SqlConnection baglan = this.baglan();
            SqlCommand komut = new SqlCommand(sqlkomut, baglan);
            SqlDataReader getir = komut.ExecuteReader();
            return getir;
        }

        // hata oluşursa -1, diğer hallerde kayıt sayısı döner
        public int getTableCount(int donem, string ogrNo)
        {
            int sonuc = -1;
            SqlConnection baglan = this.baglan();
            SqlCommand cmd = new SqlCommand("select count (ders_akts) from TRANSKRIPT AS T, DERSLER AS D where Donem=" + donem + " AND T.Ogr_No='" + ogrNo + "'AND T.DersKodu=D.ders_kod", baglan);

            try
            {
                sonuc = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch
            {
                sonuc = -1;
            }

            cmd.Dispose();
            baglan.Close();
            baglan.Dispose();

            return (sonuc);
        }

        public int getTableCounter(int Muaf, string ogrNo)
        {
            int sonuc = -1;
            SqlConnection baglan = this.baglan();
            SqlCommand cmd = new SqlCommand("select count (ders_akts) from DERSLER AS D, TRANSKRIPT AS T where Muaf=" + Muaf + " AND T.Ogr_No='" + ogrNo + "'AND T.DersKodu=D.ders_kod", baglan);

            try
            {
                sonuc = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch
            {
                sonuc = -1;
            }

            cmd.Dispose();
            baglan.Close();
            baglan.Dispose();

            return (sonuc);
        }

    }
}