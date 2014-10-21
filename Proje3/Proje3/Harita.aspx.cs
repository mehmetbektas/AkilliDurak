using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnBarcode.Barcode;
using OnBarcode.Barcode.BarcodeScanner;
using System.IO;


namespace Proje3
{
    public partial class Harita : System.Web.UI.Page
    {

        public string koordinatlar;
        public string x, y;
        public string[][] duraklar24;
        public string[][] duraklar23;
        string DurakID;
        string HatNo;

        Algoritma alg = new Algoritma();
        sqlBaglanti baglanti = new sqlBaglanti();

        protected void Page_Load(object sender, EventArgs e)
        {
            lb24gidis.Visible = false;
            lb24donus.Visible = false;
            lb23gidis.Visible = false;//lb23gidis hat24 Dönüş
            lb23donus.Visible = false;//lb23donus hat23 Dönüş
            ListBoxSaat.Visible = false;
            btnYoluGoster23.Visible = false;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        protected void btnGoster_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue.ToString() == "0")
            {
                lb24gidis.Visible = false;       //lb24gidis hat24 Gidiş
                lb24donus.Visible = false;       //lb24donus hat23 Gidiş
                lb23gidis.Visible = false;       //lb23gidis hat24 Dönüş
                lb23donus.Visible = false;       //lb23donus hat23 Dönüş
                ListBoxSaat.Visible = false;
            }
            
            else if (DropDownList1.SelectedValue.ToString() == "24")
            {
                lb24gidis.Visible = true;
                lb24donus.Visible = true;
                lb23gidis.Visible = false;//lb23gidis hat24 Dönüş
                lb23donus.Visible = false;//lb23donus hat23 Dönüş
                ListBoxSaat.Visible = false;
                btnYoluGoster23.Visible = false;
                btnYoluGoster24.Visible = true;
            }
            else if (DropDownList1.SelectedValue.ToString() == "23")
            {
                lb24gidis.Visible = false;
                lb24donus.Visible = false;
                lb23gidis.Visible = true;//lb23gidis hat24 Dönüş
                lb23donus.Visible = true;//lb23donus hat23 Dönüş
                ListBoxSaat.Visible = false;
                btnYoluGoster24.Visible = false;
                btnYoluGoster23.Visible = true;
            }


        }

        protected void btnSaat_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue.ToString() == "24")
            {
                ListBoxSaat.Items.Clear();
                StreamReader sr;
                //sr = File.OpenText(@"C:\Users\Innocent\Desktop\Proje3\Proje3\OtobusSaat\24.txt");
                sr = File.OpenText(Server.MapPath("OtobusSaat\\24.txt"));
                string str;

                while ((str = sr.ReadLine()) != null)
                {
                    ListBoxSaat.Items.Add(str.ToString());
                }

                sr.Close();

                lb24gidis.Visible = true;
                lb23gidis.Visible = true;//lb23gidis hat24 Dönüş
                ListBoxSaat.Visible = true;
            }

            if (DropDownList1.SelectedValue.ToString() == "23")
            {
                ListBoxSaat.Items.Clear();
                StreamReader sr;
                sr = File.OpenText(@"C:\Users\Innocent\Desktop\Proje3\Proje3\OtobusSaat\23.txt");

                string str;

                while ((str = sr.ReadLine()) != null)
                {
                    ListBoxSaat.Items.Add(str.ToString());
                }

                sr.Close();

                lb24donus.Visible = true;
                lb23donus.Visible = true;//lb23donus hat23 Dönüş
                ListBoxSaat.Visible = true;
                
            }
        }

        // Listelenen duraklar arasından bir durak seçilir.  Seçilen duraktan geçen otobüsler listelenir.
        protected void btnDigerHatlar_Click(object sender, EventArgs e)                                                           
        {
            string digerHatlar="Yok";
            
            if (lb24gidis.Visible == true)
            {

                if (lb24gidis.EnableTheming)
                {
                  //  digerHatlar = baglanti.dataCellGetir("select DigerHatlar from Duraklar24 where DurakID='"+lb24gidis.SelectedValue.ToString()+"' ");
                    lblHatlar.Text="24gidis";
                }
                else if (lb24donus.EnableTheming)
                {
                  //  digerHatlar = baglanti.dataCellGetir("select DigerHatlar from Duraklar24 where DurakID='" + lb24donus.SelectedValue.ToString() + "'  ");
                    lblHatlar.Text = "24donus";
                }
                lb24gidis.Visible = true;
                lb24donus.Visible = true;
                if (lblHatlar.Visible==true)
	            {
		            lblHatlar.Visible=true;
	            }

            }
            else
            {
                if (lb23gidis.EnableTheming)
                {
                    digerHatlar = baglanti.dataCellGetir("select DigerHatlar from Duraklar24 where DurakID='" + lb23gidis.SelectedValue.ToString() + "'  ");
                    lblHatlar.Text = "23gidis";
                }
                else if (lb23donus.EnableTheming)
                {
                    digerHatlar = baglanti.dataCellGetir("select DigerHatlar from Duraklar24 where DurakID='" + lb23donus.SelectedValue.ToString() + "'  ");
                    lblHatlar.Text = "23donus";
                }


	            lb23gidis.Visible = true;
                lb23donus.Visible = true;
                if (lblHatlar.Visible==true)
	            {
		            lblHatlar.Visible=true;
	            }
            }

          //  lblHatlar.Text = digerHatlar;
            

        }

        protected void ibDurak1_Click(object sender, ImageClickEventArgs e)
        {
            string[] data = BarcodeScanner.Scan(Server.MapPath("Barkodlar\\Durak1.png"), BarcodeType.QRCode);
            string[] data_ayri = data[0].Split(',');
            x = data_ayri[0];
            y = data_ayri[1];
            
            ClientScript.RegisterStartupScript(this.GetType(), "StartupScript", "DuragaGit('"+x+"','"+y+"')",true);
        }

        protected void ibDurak2_Click(object sender, ImageClickEventArgs e)
        {
            string[] data = BarcodeScanner.Scan(Server.MapPath("Barkodlar\\Durak2.png"), BarcodeType.QRCode);
            string[] data_ayri = data[0].Split(',');
            x = data_ayri[0];
            y = data_ayri[1];
            
            ClientScript.RegisterStartupScript(this.GetType(), "StartupScript", "<script type='text/javascript'>DuragaGit('" + x + "','" + y + "')</script>", false);

        }

        protected void ibDurak3_Click(object sender, ImageClickEventArgs e)
        {
            string[] data = BarcodeScanner.Scan(Server.MapPath("Barkodlar\\Durak3.png"), BarcodeType.QRCode);
            string[] data_ayri = data[0].Split(',');
            x = data_ayri[0];
            y = data_ayri[1];
            
            ClientScript.RegisterStartupScript(this.GetType(), "StartupScript", "<script type='text/javascript'>DuragaGit('" + x + "','" + y + "')</script>", false);
            
        }

        protected void ibDurak4_Click(object sender, ImageClickEventArgs e)
        {
            string[] data = BarcodeScanner.Scan(Server.MapPath("Barkodlar\\Durak4.png"), BarcodeType.QRCode);
            string[] data_ayri = data[0].Split(',');
            x = data_ayri[0];
            y = data_ayri[1];
            
            ClientScript.RegisterStartupScript(this.GetType(), "StartupScript", "<script type='text/javascript'>DuragaGit('" + x + "','" + y + "')</script>", false);
        
        }

        protected void ibDurak5_Click(object sender, ImageClickEventArgs e)
        {
            string[] data = BarcodeScanner.Scan(Server.MapPath("Barkodlar\\Durak5.png"), BarcodeType.QRCode);
            string[] data_ayri = data[0].Split(',');
            x = data_ayri[0];
            y = data_ayri[1];
            
            ClientScript.RegisterStartupScript(this.GetType(), "StartupScript", "<script type='text/javascript'>DuragaGit('" + x + "','" + y + "')</script>", false);
        
        }

        

        protected void btnYoluGoster24_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue=="24" && false)
            {
                for (int i = 0; i < 46; i++)
                {
                    koordinatlar = baglanti.dataCellGetir("select koordinat from Duraklar24 where DurakID='"+i+1+"'").ToString();
                    duraklar24[i] = koordinatlar.Split(',');
                }
                
            }
            if (DropDownList1.SelectedValue == "23" && false)
            {
                for (int i = 0; i < 39; i++)
                {
                    koordinatlar = baglanti.dataCellGetir("select koordinat from Duraklar24 where DurakID='" + i + 1 + "'").ToString();
                    duraklar23[i] = koordinatlar.Split(',');
                }
            }
            

        }

        protected void btnHat_Click(object sender, EventArgs e)
        {
            Response.Redirect("HatDetay.aspx?HatNo=" + HatNo + "&DurakNo=" + DurakID + "");

        }

       
        protected void lb24gidis_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHatlar.Text = baglanti.dataCellGetir("select DigerHatlar from Duraklar23 where DurakID='" + lb24gidis.SelectedItem.Value.ToString() + "'");
            DurakID = (lb24gidis.SelectedItem.Value.ToString()).Trim();
            HatNo = "24";
        }

        protected void lb23gidis_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHatlar.Text = baglanti.dataCellGetir("select DigerHatlar from Duraklar23 where DurakID='" + lb23gidis.SelectedItem.Value.ToString() + "'");
            DurakID = (lb23gidis.SelectedItem.Value.ToString()).Trim();
            HatNo = "23";
        }

        protected void lb24donus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHatlar.Text = baglanti.dataCellGetir("select DigerHatlar from Duraklar23 where DurakID='" + lb24donus.SelectedItem.Value.ToString() + "'");
            DurakID = (lb24donus.SelectedItem.Value.ToString()).Trim();
            HatNo = "24";
        }

        protected void lb23donus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHatlar.Text = baglanti.dataCellGetir("select DigerHatlar from Duraklar23 where DurakID='" + lb23donus.SelectedItem.Value.ToString() + "'");
            DurakID = (lb23donus.SelectedItem.Value.ToString()).Trim();
            HatNo = "23";
        }

        protected void btnYoluGoster23_Click(object sender, EventArgs e)
        {

        }        

    }
}