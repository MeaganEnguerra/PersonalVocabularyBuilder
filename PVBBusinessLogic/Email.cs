using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using Microsoft.Extensions.Configuration;


namespace EmailFunc
{
    public class EmailSMTP
    {
        private readonly IConfiguration _configuration;

        public EmailSMTP  (IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void SendEmail(string username, string password)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(
                _configuration["EmailSettings:FromName"],
                _configuration["EmailSettings:FromEmail"]
                ));

                
            message.To.Add(new MailboxAddress("Account User", "user@gmail.com"));
            message.Subject = "Account Notifier";
            message.Body = new TextPart("plain")

            {
                Text = $"User: {username}\n\n\nWelcome to Vocabulary Builder! \n Start building your own collection of " +
                $"vocabularies! LEARN AND HAVE FUN!"
            };



            using (var client = new SmtpClient())
            {
               

                client.Connect(
                   _configuration["EmailSettings:SmtpHost"],
                    int.Parse(_configuration["EmailSettings:SmtpPort"]),
                    SecureSocketOptions.StartTls
                );

                client.Authenticate(
                    _configuration["EmailSettings:Username"],
                    _configuration["EmailSettings:Password"]
                );

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}