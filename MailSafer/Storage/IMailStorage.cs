namespace MailSafer.Storage
{
    using System.Net.Mail;

    public interface IMailStorage
    {
        void Save(MailMessage mailMessage);
    }
}