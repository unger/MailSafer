namespace MailSafer
{
    public interface IMailStorage
    {
        void Save(IEmailMessage mailMessage);
    }
}