using System;
using MvcWebAppWithUserAccounts.Models;

namespace MvcWebAppWithUserAccounts.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}

