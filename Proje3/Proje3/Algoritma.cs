using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using System.IO;

namespace Proje3
{
    public class Algoritma
    {
        
        

        public string DurakNo;
        public string HatNo;
        public string Neden;
        public string HavaDurumu;
        public string Saat;
        public string Gecikme;
        public string Cevap;

        int sTumu = 0, k=0,l=0;
        double[] sNeden = { 0,0,0,0,0,0,0 };
        double[] sHavaDurumu = { 0,0,0,0,0,0,0 };
        double[] sAralik = { 0,0,0,0,0,0,0 };
        double[] sonuc = new double[7];

        
        
        public void Fonksiyon()
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int)); 
            dt.Columns.Add("GecKalma", typeof(string));  
            dt.Columns.Add("Neden", typeof(string));  
            dt.Columns.Add("HavaDurumu", typeof(string));  
            dt.Columns.Add("DOGS", typeof(string));  
            dt.Columns.Add("Hatno", typeof(string));
            dt.Columns.Add("DurakNo", typeof(string));

            StreamReader sr;
            sr = File.OpenText(@"C:\Users\Innocent\Desktop\Proje3\Proje3\ornekler_min.txt");
            
            string str;
            
            while ((str = sr.ReadLine()) != null)
            {
                string[] strDizi = str.Split(',');
                if (strDizi[5] == HatNo && strDizi[6] == DurakNo)
                { 
                    dt.Rows.Add(strDizi[0], strDizi[1], strDizi[2], strDizi[3], strDizi[4], strDizi[5], strDizi[6]);
                    k++;
                }
                else l++;
            }
            
            sr.Close();
//////////////////////////////////////////////////////////////////////////////

            k++;
            l++;
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["GecKalma"])>0 && Convert.ToInt32(row["GecKalma"]) <=5 )
                {
                    if (row["Neden"].ToString()==Neden)
                    {
                    sNeden[0]++;
                    }
                    if (row["HavaDurumu"].ToString() == HavaDurumu)
                    {
                    sHavaDurumu[0]++;
                    }

                    sAralik[0]++;
                }

                if (Convert.ToInt32(row["GecKalma"]) >= 6 && Convert.ToInt32(row["GecKalma"]) <= 10)
                {
                    if (row["Neden"].ToString() == Neden)
                    {
                        sNeden[1]++;
                    }
                    if (row["HavaDurumu"].ToString() == HavaDurumu)
                    {
                        sHavaDurumu[1]++;
                    }

                    sAralik[1]++;
                }


                if (Convert.ToInt32(row["GecKalma"]) >=11 && Convert.ToInt32(row["GecKalma"]) <= 15)
                {
                    if (row["Neden"].ToString() == Neden)
                    {
                        sNeden[2]++;
                    }
                    if (row["HavaDurumu"].ToString() == HavaDurumu)
                    {
                        sHavaDurumu[2]++;
                    }

                    sAralik[2]++;
                }



                if (Convert.ToInt32(row["GecKalma"]) >=16 && Convert.ToInt32(row["GecKalma"]) <= 20)
                {
                    if (row["Neden"].ToString() == Neden)
                    {
                        sNeden[3]++;
                    }
                    if (row["HavaDurumu"].ToString() == HavaDurumu)
                    {
                        sHavaDurumu[3]++;
                    }

                    sAralik[3]++;
                }


                if (Convert.ToInt32(row["GecKalma"]) >= 21 && Convert.ToInt32(row["GecKalma"]) <= 25)
                {
                    if (row["Neden"].ToString() == Neden)
                    {
                        sNeden[4]++;
                    }
                    if (row["HavaDurumu"].ToString() == HavaDurumu)
                    {
                        sHavaDurumu[4]++;
                    }

                    sAralik[4]++;
                }


                

                if (Convert.ToInt32(row["GecKalma"]) >= 26 && Convert.ToInt32(row["GecKalma"]) <= 30)
                {
                    if (row["Neden"].ToString() == Neden)
                    {
                        sNeden[5]++;
                    }
                    if (row["HavaDurumu"].ToString() == HavaDurumu)
                    {
                        sHavaDurumu[5]++;
                    }

                    sAralik[5]++;
                }


                

                if (Convert.ToInt32(row["GecKalma"]) >= 31)
                {
                    if (row["Neden"].ToString() == Neden)
                    {
                        sNeden[6]++;
                    }
                    if (row["HavaDurumu"].ToString() == HavaDurumu)
                    {
                        sHavaDurumu[6]++;
                    }

                    sAralik[6]++;
                }

                sTumu++;
                Saat = row["DOGS"].ToString();
            }
            

            double enb=0;
            
            for (int i = 0; i < 7; i++)
			{
			    sonuc[i] = ((sAralik[i] / sTumu)) * ((sNeden[i] / sAralik[i])) * ((sHavaDurumu[i] / sAralik[i]));
                if (sonuc[i] >= enb)
                {
                    enb = sonuc[i];
                    k = i;
                }
            }

            switch (k)
            {
                case 0: Gecikme = "00:03"; break;
                case 1: Gecikme = "00:08"; break;
                case 2: Gecikme = "00:13"; break;
                case 3: Gecikme = "00:18"; break;
                case 4: Gecikme = "00:23"; break;
                case 5: Gecikme = "00:28"; break;
                case 6: Gecikme = "00:33"; break;
            }
            Cevap = (Convert.ToDateTime(Saat).Hour + Convert.ToDateTime(Gecikme).Hour).ToString();

            HatDetay hd = new HatDetay();
            hd.DNo = DurakNo;
            hd.HNo = HatNo;
            hd.Sa = Saat;
            hd.Ge = Gecikme;
            hd.Mu = Cevap;

        }

    }
}