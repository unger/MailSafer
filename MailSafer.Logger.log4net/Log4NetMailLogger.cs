namespace MailSafer.Logger
{
    using System;
    using System.Net.Mail;

    using log4net;

    public class Log4NetMailLogger : IMailLogger
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Log4NetMailLogger));

        public void Info(string message, MailMessage mailMessage)
        {
            Log.InfoFormat("{0} {1} {2} {3}", message, mailMessage.From, mailMessage.To, mailMessage.Subject);
        }

        public void Error(string message, MailMessage mailMessage, Exception exception)
        {
            Log.Error(string.Format("{0} {1} {2} {3}", message, mailMessage.From, mailMessage.To, mailMessage.Subject), exception);
        }
    }
}
