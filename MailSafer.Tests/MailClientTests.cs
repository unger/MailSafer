using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSafer.Tests
{
    using System.Net.Mail;

    using MailSafer.Delivery;
    using MailSafer.Logger;
    using MailSafer.Storage;

    using NUnit.Framework;

    [TestFixture]
    public class MailClientTests
    {
        [Test]
        public void Send()
        {
            var client = new MailClient(new SmtpClientDelivery(new SmtpClient("localhost")), new NullMailStorage(), new NullMailLogger());
            var mail = new EmailMessage();
            mail.From = new MailAddress("test@test.test");
            mail.To = new MailAddress("test@test.test");
            mail.Subject = "Subject";
            mail.Body = "Body";

            client.Send(mail);
        }
    }
}
