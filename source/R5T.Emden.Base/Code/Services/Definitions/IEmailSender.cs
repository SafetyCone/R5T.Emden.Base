using System;
using System.Net.Mail;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Emden
{
    /// <summary>
    /// A service that sends emails.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IEmailSender : IServiceDefinition
    {
        //HACK: Will fill in the "From" address.
        void Send(MailMessage message);

        Task SendAsync(MailMessage message);
    }
}
