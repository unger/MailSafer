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
            const string Expected = 
@"From: info@test.com
To: info@test.com
Subject: Test";
            var headers = MailMessageSerializer.SerializeHeaders(new MailMessage("info@test.com", "info@test.com")
                                                                     {
                                                                         Subject = "Test"
                                                                     });

            Assert.AreEqual(Expected, headers);
        }

        [Test]
        public void SerializeHeaders_WithMultipleRecipients()
        {
            const string Expected =
@"From: info@test.com
To: info1@test.com,info2@test.com
Subject: Test";

            var mailMessage = new MailMessage { From = new MailAddress("info@test.com"), Subject = "Test" };
            mailMessage.To.Add("info1@test.com, info2@test.com");

            var headers = MailMessageSerializer.SerializeHeaders(mailMessage);

            Assert.AreEqual(Expected, headers);
        }
    }
}
