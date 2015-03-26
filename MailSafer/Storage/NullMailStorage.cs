namespace MailSafer.Storage
{
    using System.Net.Mail;

    public class NullMailStorage : IMailStorage
    {
        public void Save(MailMessage mailMessage)
        {
        }
    }
}
