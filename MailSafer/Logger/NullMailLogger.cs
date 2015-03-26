namespace MailSafer.Logger
{
    using System;
    using System.Net.Mail;

    public class NullMailLogger : IMailLogger
    {
        public void Info(string message, MailMessage mailMessage)
        {
        }

        public void Error(string message, MailMessage mailMessage, Exception exception)
        {
        }
    }
}
