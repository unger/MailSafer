namespace MailSafer.Logger
{
    using System;
    using System.Net.Mail;

    public interface IMailLogger
    {
        void Info(string message, MailMessage mailMessage);

        void Error(string message, MailMessage mailMessage, Exception exception);
    }
}