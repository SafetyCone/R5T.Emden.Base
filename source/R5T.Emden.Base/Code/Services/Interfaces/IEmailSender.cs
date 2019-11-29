using System;
using System.Net.Mail;


namespace R5T.Emden
{
    /// <summary>
    /// A service that sends emails.
    /// </summary>
    public interface IEmailSender
    {
        void Send(MailMessage message);
    }
}
