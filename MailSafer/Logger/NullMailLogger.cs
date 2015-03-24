using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSafer.Logger
{
    public class NullMailLogger : IMailLogger
    {
        public void Info(string message, IEmailMessage mailMessage)
        {
        }

        public void Error(string message, IEmailMessage mailMessage, Exception exception)
        {
        }
    }
}
