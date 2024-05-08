using System.Net;
using System.Net.Mail;

using System.Net;
using System.Net.Mail;

namespace Email {
    public class EmailSender {
        
        public void send(string ReceiverUser) {
            // Set up SMTP client
            SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com");
            smtpClient.Port = 587; 
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            System.Net.NetworkCredential credential = new System.Net.NetworkCredential("iauarastirmavegelistirme@hotmail.com", "yourpassword");
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = credential;

            // Create a mail message
            MailMessage mailMessage = new MailMessage("iauarastirmavegelistirme@hotmail.com", ReceiverUser);
            mailMessage.Subject = "Test";
            mailMessage.Body = "<h1>This is a test mail</h1>";
            mailMessage.IsBodyHtml = true; // Set to true if you're sending HTML content

            // Add attachment
            Attachment attachment = new Attachment(@"C:\Users\Cafer Celal Evrenüz\Desktop\cvlik foto.jpeg");
            mailMessage.Attachments.Add(attachment);

            // Send the email
            smtpClient.Send(mailMessage);

            // Dispose the attachment
            attachment.Dispose();
        }
    }
}
