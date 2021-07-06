﻿using System.Net;
using System;
using System.Net.Mail;
using System.IO;
namespace Academy
{
    static class Mail
    {
        private static SmtpClient SmtpClient { get; set; }
        private static string SenderAddress { get; } = "asoiuexam1920@gmail.com";
        private static string SenderPassword { get; } = "asoiuexam.123";
        static Mail()
        {
            SmtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(SenderAddress, SenderPassword),
                EnableSsl = true
            };
        }

        public static void SendMail(in string recipient, in string subject, in string body)
        {
            string html = $@"<h1 style='background-color:#00bfff;padding:25px;border-radius:15px;border:5px solid red'>" + body + "</h1>";
            string fileName = "Exam.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(SenderAddress);
                mail.To.Add(recipient);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = html;
                mail.Attachments.Add(new Attachment(path));
                SmtpClient.Send(mail);
            }
        }
    }
}
