using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace EmailFunc
{
    public class EmailSMTP
    {
        public void SendEmail(string username, string password)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Vocabulary App", "do-not-reply@atm.com"));
            message.To.Add(new MailboxAddress("Account User", "user@gmail.com"));
            message.Subject = "Account Notifier";
            message.Body = new TextPart("plain")
            {
                Text = $"User: {username}\nPassword: {password}\n\nWelcome to Vocabulary Builder! \n"
            };

            using (var client = new SmtpClient())
            {
                var smtpHost = "sandbox.smtp.mailtrap.io";
                var smtpPort = 2525;
                var tls = MailKit.Security.SecureSocketOptions.StartTls;

                client.Connect("sandbox.smtp.mailtrap.io", 2525, SecureSocketOptions.None);


                var userName = "b64f9c309756bd";  
                var passWord = "5ce73b5db00f87";  

                client.Authenticate(userName, passWord);

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
