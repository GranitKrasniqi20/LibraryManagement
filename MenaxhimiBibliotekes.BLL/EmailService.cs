using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;


namespace MenaxhimiBibliotekes.BLL
{
    public class EmailService
    {

        SmtpClient client;
        string smtpserver = "smtp.gmail.com";
        int port = 587;
        bool EnableSsl = true;



        public void SendMails(string to, string subject,string message)
        {
            try
            {
                client = new SmtpClient(smtpserver, port);
                client.EnableSsl = EnableSsl;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("stackbooks.corporations@gmail.com", "stackbooks123");
                MailMessage msg = new MailMessage();
                msg.To.Add(to);
                msg.From = new MailAddress("stackbooks.corporations@gmail.com");
                msg.Subject = subject;
                msg.Body = message;
                client.Send(msg);
            }
            catch (Exception)
            {

            }
            

        }
    }
}
