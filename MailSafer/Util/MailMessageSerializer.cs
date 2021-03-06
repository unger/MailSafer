﻿namespace MailSafer.Util
{
    using System.Net.Mail;
    using System.Text;

    public class MailMessageSerializer
    {
        public static string SerializeHeaders(MailMessage mailMessage)
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Format("From: {0}", mailMessage.From));
            sb.AppendLine(string.Format("To: {0}", string.Join(",", mailMessage.To)));
            sb.AppendLine(string.Format("Subject: {0}", mailMessage.Subject));
            
            foreach (var headerKey in mailMessage.Headers.AllKeys)
            {
                sb.AppendFormat("{0}: {1}", headerKey, mailMessage.Headers[headerKey]);
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public static string Serialize(MailMessage mailMessage)
        {
            var sb = new StringBuilder(SerializeHeaders(mailMessage));

            sb.AppendLine();
            sb.AppendLine();
            sb.Append(mailMessage.Body);

            return sb.ToString();
        }
    }
}
