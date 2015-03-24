namespace MailSafer.Delivery
{
    public interface IMailDelivery
    {
        void Send(IEmailMessage mailMessage);
    }
}