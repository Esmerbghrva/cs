using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailBomber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FromMail = "thedotnetchannelsender22@gmail.com";
            string FromPassword = "lgioehkvchemfkrw";


            //Create a new mail
            MailMessage message = new MailMessage();
            message.From = new MailAddress(FromMail);
            message.Subject = "Test mail from workshop!";
            List<string> mail = new List<string>() { "esmerbaghirov675@gmail.com", "narimanovamuhaddisanm@gmail.com" };
            //message.To.Add(new MailAddress("esmerbaghirov675@gmail.com"));
            message.Body = "Test body from workshop";

            //SMTP configuration
            var smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential(FromMail, FromPassword);
            smtpClient.EnableSsl = true;
            foreach (string mailItem in mail)
            {
                message.To.Add(new MailAddress(mailItem));
                try
                {

                    smtpClient.Send(message);
                    Console.WriteLine("Successful");

                    Thread.Sleep(3000);
                    Console.ReadLine();
                }

                catch
                {

                    Console.WriteLine("Fail");
                    Console.ReadLine();

                }
            }



            //Sending message





        }
    }
}