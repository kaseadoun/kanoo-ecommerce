using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Kanoo.Models
{
    // This class handles the logic for sending users an email through the ASP.NET API
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string name, string message)
        {
            // Get the login info for our SMTP server from appsettings.Development.json
            var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.Development.json");

            // Grab the required values from the given keys in appsettings.Development.json
            var config = builder.Build();
            var host = config["Gmail:Host"];
            var port = int.Parse(config["Gmail:Port"]);
            var username = config["Gmail:Username"];
            var pwd = config["Gmail:Password"];

            // Configure the values of our product's SMTP headers and establish a connection to the SMTP server
            var client = new SmtpClient()
            {
                Host = host,
                Port = port,
                Credentials = new NetworkCredential(username, pwd),
                EnableSsl = true,
            };

            // Send the mail!
            return client.SendMailAsync(
                new MailMessage(from: username,
                                to: email,
                                "Form Received",
                                "Hello " + name + ",\n" + 
                                "We have received the following message and will respond to you shortly:\n\n" +
                                message
                                ));
        }
    }
}