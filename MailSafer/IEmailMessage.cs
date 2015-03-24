namespace MailSafer
{
    using System.Net.Mail;

    public interface IEmailMessage
    {
        MailAddress From { get; set; }

        MailAddress To { get; set; }

        string Subject { get; set; }

        string Body { get; set; }
    }
}