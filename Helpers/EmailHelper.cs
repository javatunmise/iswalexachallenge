using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace alexa_challenge.Helpers
{
    public class EmailHelper
    {
        public static void SendMail(string email, string mailsubject, string message)
        {

            var emailAddress = "boluwah2012@gmail.com";

            var toAddress = email;
            const string myPassWord = "bohluwah12";
            string subject = mailsubject;
            string body = message;

            var smtp = new System.Net.Mail.SmtpClient();
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                //smtp.Credentials=new NetworkCredential()
                smtp.Credentials = new NetworkCredential(emailAddress, myPassWord);
                smtp.Timeout = 20000;
            }

            smtp.Send(emailAddress, toAddress, subject, body);
        }
    }
}
