using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace testEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string from = "andrew.demidyuk@gmail.com";
            string pass = "Andre00Demid11";
            string to = "demidronone@gmail.com";
            string host = "smtp.gmail.com";
            int port = 587;
            string text = "Hi";


            using (MailMessage mailMessage = new MailMessage(from, to, "Message Subject", text))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "My Subject";
                mailMessage.Body = "Text in the body";

                smtpClient.Host = host;
                smtpClient.Port = port;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(from, pass);

                smtpClient.Send(mailMessage);
            }


            //SmtpClient client = new SmtpClient(host, port)
            //{
            //    DeliveryMethod = SmtpDeliveryMethod.Network,
            //    UseDefaultCredentials = false,
            //    Credentials = new System.Net.NetworkCredential(from, pass),
            //    EnableSsl = true
            //};

            //// создаем письмо: to - адрес получателя
            //var mail = new MailMessage(from, to, "Message Subject", text);

            ////Для отправкии вызиваем метод Send обекта client
            //client.Send(mail);
            //Console.WriteLine("Sended");
            //Console.ReadLine();
        }
    }
}
