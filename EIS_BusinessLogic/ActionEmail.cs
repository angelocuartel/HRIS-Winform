using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
namespace EIS_BusinessLogic
{
   public static class ActionEmail
    {

        public static void SendMail(string email,string body)
        {

            MailMessage msg = new MailMessage()
            {
                From = new MailAddress("QCU.EIS.NoReply@gmail.com"),

                Body = body,
                Subject = "Qcu Employee Information default Account"

            };
            msg.To.Add(email);

            NetworkCredential mailAccSender = new NetworkCredential()
            {
                // change your mail server
                UserName = "",
                Password = "",
            };

            SmtpClient smtp = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Credentials = mailAccSender,
                EnableSsl = true,
                Port = 587
            };
            smtp.SendMailAsync(msg);
        }
         

        }
    }


