﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace TrackerLibrary
{
    public static class EmailLogic
    {
        public static void SendEmail(string to, string subject, string body)
        {
            SendEmail(new List<string> { to }, new List<string>(), subject, body);
        }

        public static void SendEmail(List<string> to, List<string> bcc, string subject, string body)
        {
            MailAddress fromMailAddress = new MailAddress(GlobalConfig.AppKeyLookup("sender"), GlobalConfig.AppKeyLookup("senderDisplayName"));

            MailMessage mail = new MailMessage();
            foreach (var email in to)
            {
                mail.To.Add(email); 
            }
            foreach (var email in bcc)
            {
                mail.Bcc.Add(email);
            }
            mail.From = fromMailAddress;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();

            client.Send(mail);

        }
    }
}
