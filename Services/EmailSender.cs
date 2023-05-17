using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace MvcWebAppWithUserAccounts.Services;

public class EmailSender : IEmailSender
{
    public EmailSender()
    {

    }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
    public async Task SendEmailAsync(string email, string subject, string htmlMessage)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
    {
        string fromMail = "andypyc";
        string fromMailEmail = "andy@revistapyc.com";
        string fromPassword = "Andyrevista123";

        MailMessage message = new MailMessage();
        message.From = new MailAddress(fromMailEmail);
        message.Subject = subject;
        message.To.Add(new MailAddress(email));
        message.Body = "<html><body> " + htmlMessage + " </body></html>";
        message.IsBodyHtml = true;

        var smtpClient = new SmtpClient("smtp.us.opalstack.com")
        {
            Port = 587,
            Credentials = new NetworkCredential(fromMail, fromPassword),
            EnableSsl = true,
        };
        smtpClient.Send(message);
    }
}
