namespace MailSafer.Storage
{
    using System.IO;
    using System.Net.Mail;

    public class FileSystemMailStorage : IMailStorage
    {
        private readonly string path;

        public FileSystemMailStorage(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new DirectoryNotFoundException(string.Format("Folder does not exist: {0}", path));
            }

            this.path = path;
        }

        public void Save(MailMessage mailMessage)
        {
            this.CreateEmlFile(mailMessage);
        }

        private void CreateEmlFile(MailMessage mailMessage)
        {
            using (var client = new SmtpClient())
            {
                client.UseDefaultCredentials = true;
                client.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                client.PickupDirectoryLocation = this.path;
                client.Send(mailMessage);
            }
        }
    }
}
