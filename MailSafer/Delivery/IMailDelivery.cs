namespace MailSafer.Delivery
{
    using System.Net.Mail;

    public interface IMailDelivery
    {
        void Send(MailMessage mailMessage);
    }
}