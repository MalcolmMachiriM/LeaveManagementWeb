using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagement.Web.Services
{
    public class EmailSenderr : IEmailSender
    {
        private string smtpServer;
        private int smtpPort;
        private string fromEmailAddress;

        public EmailSenderr(string smtpServer, int smtpPort, string fromEmailAddress)
        {
            this.smtpServer = smtpServer;
            this.smtpPort = smtpPort;
            this.fromEmailAddress = fromEmailAddress;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var messages = new MailMessage
            {
                From=new MailAddress(fromEmailAddress),
                Subject=subject,
                Body=htmlMessage,
                IsBodyHtml = true
            };

            messages.To.Add(new MailAddress(email));

            using var client = new SmtpClient(smtpServer, smtpPort);
            client.Send(messages);

            return Task.CompletedTask;
            
        }
    }
}
