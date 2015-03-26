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
        [Ignore]
        [Test]
        public void Send_Email()
        {
            var client = new MailClient(
                new SmtpClientDelivery("localhost"),
                new FileSystemMailStorage(@"c:\Temp\MailStorage"), 
                new NullMailLogger());

            var mail = new MailMessage();
            mail.From = new MailAddress("test@test.test");
            mail.To.Add(new MailAddress("test@test.test"));
            mail.Subject = "Subject";
            mail.Body = "Body";

            client.Send(mail);
        }
    }
}
