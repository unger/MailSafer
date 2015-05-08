using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSafer.Tests
{
    using System.Net.Mail;

    using MailSafer.Util;

    using NUnit.Framework;

    [TestFixture]
    public class MailMessageSerializerTests
    {
        [Test]
        public void SerializeHeaders_WithSingleRecipient()
        {
            var expected = new StringBuilder();
            expected.AppendLine("From: info@test.com");
            expected.AppendLine("To: info@test.com");
            expected.AppendLine("Subject: Test");

            var headers = MailMessageSerializer.SerializeHeaders(new MailMessage("info@test.com", "info@test.com")
                                                                     {
                                                                         Subject = "Test"
                                                                     });

            Assert.AreEqual(expected.ToString(), headers);
        }

        [Test]
        public void SerializeHeaders_WithMultipleRecipients()
        {
            var expected = new StringBuilder();
            expected.AppendLine("From: info@test.com");
            expected.AppendLine("To: info1@test.com,info2@test.com");
            expected.AppendLine("Subject: Test");

            var mailMessage = new MailMessage { From = new MailAddress("info@test.com"), Subject = "Test" };
            mailMessage.To.Add("info1@test.com, info2@test.com");

            var headers = MailMessageSerializer.SerializeHeaders(mailMessage);

            Assert.AreEqual(expected.ToString(), headers);
        }
    }
}
