using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Email_Sender
{
	public class EmailSender : IEmailSender
	{
		public void SendMail(string email, string subject, string message)
		{
			var mail = "dotnettestmailsender@gmail.com";
			var password = "";
			var client = new SmtpClient("smtp.gmail.com", 587)
			{
				EnableSsl = true,
				Credentials = new NetworkCredential(mail, password)
			};
			client.Send(new MailMessage(from: mail, to: email, subject, message));
		}
	}
}

