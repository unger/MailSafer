using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSafer.Delivery
{
    using System.Net.Mail;

    public class SmtpClientDelivery : IMailDelivery
    {
        private readonly SmtpClient smtpClient;

        public SmtpClientDelivery(SmtpClient smtpClient)
        {
            this.smtpClient = smtpClient;
        }

        public void Send(IEmailMessage mailMessage)
        {
            var mail = new MailMessage();
            mail.From = mailMessage.From;
            mail.To.Add(mailMessage.To);
            mail.Subject = mailMessage.Subject;
            mail.Body = mailMessage.Body;

            this.smtpClient.Send(mail);
        }
    }
}
