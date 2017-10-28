using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
namespace sendmail
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*Program ab = new Program();
            ab.email_send();*/

            string s = "tamquocqn20@gmail.com, Your Amazon.com Card is Here! USD $1.00 Amazon.com Gift Card claim code: QEGR-JCK56D-HFXU From: support@rewardbox.net Amazon.com Gift Cards* never expire and can be redeemed towards millions of items at";
            int vt = s.Trim().IndexOf(":");
            Console.WriteLine(s.IndexOf("code:"));
           
            string key = s.Substring(vt+1,17);
            Console.WriteLine("Chuoi la:{0}",key);
            Console.ReadLine();
        }
        public void email_send()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("cty.nasic@gmail.com");
            mail.To.Add("thienvi147159@gmail.com");
            mail.Subject = "Test Mail - 1";
            mail.Body = "Cái Gì Đây";

          /*  System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            mail.Attachments.Add(attachment);*/

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("cty.nasic@gmail.com", "*******");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            Console.ReadLine();
        }
    }
}
