using System;
using System.Net.Mail;


namespace R5T.Emden
{
    /// <summary>
    /// A service that sends emails.
    /// </summary>
    public interface IEmailSender
    {
        // Will fill in the "From" address.
        void Send(MailMessage message);
    }
}
