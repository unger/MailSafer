namespace MailSafer.Storage
{
    public class NullMailStorage : IMailStorage
    {
        public void Save(IEmailMessage mailMessage)
        {
        }
    }
}
