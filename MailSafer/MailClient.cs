namespace MailSafer
{
    using System;
    using System.Net.Mail;

    using MailSafer.Delivery;
    using MailSafer.Logger;
    using MailSafer.Storage;

    public class MailClient
    {
        private readonly IMailDelivery delivery;

        private readonly IMailStorage storage;

        private readonly IMailLogger logger;

        public MailClient(IMailDelivery delivery, IMailStorage storage, IMailLogger logger)
        {
            this.delivery = delivery;
            this.storage = storage;
            this.logger = logger;
        }

        public void Send(MailMessage mailMessage)
        {
            try
            {
                this.storage.Save(mailMessage);
            }
            catch (Exception e)
            {
                this.logger.Error("Error saving email", mailMessage, e);
                throw;
            }

            try
            {
                this.delivery.Send(mailMessage);
            }
            catch (Exception e)
            {
                this.logger.Error("Error sending email", mailMessage, e);
                throw;
            }
        }
    }
}
