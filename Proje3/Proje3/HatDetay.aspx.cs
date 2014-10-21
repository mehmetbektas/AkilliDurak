using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Net;
using System.Net.Mail;


namespace Proje3
{
    public partial class HatDetay : System.Web.UI.Page
    {
        public string sonuc;
        
        string DurakNo;
        string HatNo;

        public string DNo;
        public string HNo;
        public string Sa;
        public string Ge;
        public string Mu;

        Algoritma alg = new Algoritma();

        protected void Page_Load(object sender, EventArgs e)
        {
            DurakNo = Request.QueryString["DurakNo"];
            HatNo = Request.QueryString["HatNo"];
            lblDurakNo.Text = DurakNo;
            lblHatNo.Text = HatNo;
            lblDOGS.Text = alg.Saat;
        }

        protected void btnHesapla_Click(object sender, EventArgs e)
        {
            alg.HavaDurumu = ddlHavaDurumu.Text;
            alg.Neden = ddlNeden.Text;
            alg.DurakNo = DurakNo;
            alg.HatNo = HatNo;

            alg.Fonksiyon();

            lblDOGS.Text = alg.Saat;
            lblGecikme.Text = alg.Gecikme;
            lblGelecegiSaat.Text = alg.Cevap;
            
        }

        protected void btnMail_Click(object sender, EventArgs e)
        {
            
                MailMessage mail = new MailMessage(); // mail adında MailMessage nesnesi yaratıyoruz.
                mail.From = new MailAddress("mehmetbektas69@gmail.com"); //Mailin kimden gittiğini belirtiyoruz
                mail.To.Add(txtMail.Text); //Mailin kime gideceğini belirtiyoruz
                mail.Subject = "Akıllı Durak Sistemi Otobüs Saati Bilgilendirmesi"; //Mail konusu
                mail.Body =HNo+"numaralı hattın "+DNo+"numaralı durağında beklemektesiniz."+
                    "Otobüsünüz saat"+Sa+"'da durakta olması gerekirken, "
                    +Ge+"'lik bir gecikme ile saat "+Mu+"'da gelecektir. İyi Günler Dileriz..."; //Mailin içeriği
                SmtpClient sc = new SmtpClient(); //sc adında SmtpClient nesnesi yaratıyoruz.
                sc.Port = 587; //Gmail için geçerli Portu bildiriyoruz
                sc.Host = "smtp.gmail.com"; //Gmailin smtp host adresini belirttik
                sc.EnableSsl = true; //SSL’i etkinleştirdik.
                sc.Credentials = new NetworkCredential("mehmetbektas69@gmail.com", "+engineer60"); //Gmail hesap kontrolü için bilgilerimizi girdik
                sc.Send(mail); //Mailinizi gönderiyoruz.
           
        }
    }
}




