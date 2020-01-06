using System;
using System.Net.Mail;
using System.Threading.Tasks;



namespace R5T.Emden
{
    /// <summary>
    /// A service that sends emails.
    /// </summary>
    public interface IEmailSender
    {
        //HACK: Will fill in the "From" address.
        void Send(MailMessage message);

        Task SendAsync(MailMessage message);
    }
}
