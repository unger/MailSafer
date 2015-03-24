using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSafer
{
    using MailSafer.Delivery;
    using MailSafer.Logger;

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

        public void Send(IEmailMessage mailMessage)
        {
            this.storage.Save(mailMessage);

            try
            {
                this.delivery.Send(mailMessage);
            }
            catch (Exception e)
            {
                this.logger.Error("Error sending email", mailMessage, e);
            }
        }
    }
}
