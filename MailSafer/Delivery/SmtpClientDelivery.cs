namespace MailSafer.Delivery
{
    using System.Net.Mail;

    public class SmtpClientDelivery : IMailDelivery
    {
        private readonly string host;

        private readonly int port;

        public SmtpClientDelivery()
            : this(null, 0)
        {
        }

        public SmtpClientDelivery(string host)
            : this(host, 0)
        {
        }

        public SmtpClientDelivery(string host, int port)
        {
            this.host = host;
            this.port = port;
        }

        public void Send(MailMessage mailMessage)
        {
            using (var smtp = this.CreateSmtpClient())
            {
                smtp.Send(mailMessage);
            }
        }

        private SmtpClient CreateSmtpClient()
        {
            if (!string.IsNullOrEmpty(this.host) && this.port != 0)
            {
                return new SmtpClient(this.host, this.port);
            }
            
            if (!string.IsNullOrEmpty(this.host))
            {
                return new SmtpClient(this.host);
            }

            return new SmtpClient();
        }
    }
}
