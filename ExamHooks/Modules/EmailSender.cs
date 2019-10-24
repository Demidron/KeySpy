using ExamHooks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ExamHooks.Modules
{
    class EmailSender : ISender
    {
        private readonly string FromEmailAddress = "example@gmail.com";
        private readonly string PassFromEmailAddress = "examplepass";
        private readonly string ToEmailAddress  = "example@gmail.com";
        private readonly string host = "smtp.gmail.com";
        private readonly int port = 587;

        public EmailSender(string emailAddress)
        {
            ToEmailAddress = emailAddress;
        }

        public Task SendString(string text)
       {
            MailMessage mailMessage = new MailMessage(FromEmailAddress, ToEmailAddress, "Message Subject", text)
            {
                Subject = "My Subject",
                Body = text
            };

            SmtpClient smtpClient = new SmtpClient
            {
                Host = host,
                Port = port,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(FromEmailAddress, PassFromEmailAddress)
            };
            return Task.Run(()=> smtpClient.SendAsync(mailMessage,true));
            
        }
    }
}
