using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Email_Sender
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IEmailSender sender = new EmailSender();
			Console.WriteLine("Wpisz adres email adresata");
			var email = Console.ReadLine();
			Console.WriteLine("Wpisz tytuł maila");
			var subject = Console.ReadLine();
			Console.WriteLine("Wpisz treść");
			var msg = Console.ReadLine();
			sender.SendMail(email, subject, msg);
		}
	}
}
