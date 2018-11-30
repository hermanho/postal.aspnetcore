using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Postal
{
    public interface IEmailSender
    {
        Task SendEmailAsync(MailMessage mailMessage);
        Task SendEmailAsync(Email emailData);
    }
}
