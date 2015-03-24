namespace MailSafer
{
    using System.Net.Mail;

    public class EmailMessage : IEmailMessage
    {
        public MailAddress From { get; set; }

        public MailAddress To { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }
    }
}
