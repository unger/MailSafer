namespace MailSafer.Logger
{
    using System;

    public interface IMailLogger
    {
        void Info(string message, IEmailMessage mailMessage);

        void Error(string message, IEmailMessage mailMessage, Exception exception);
    }
}