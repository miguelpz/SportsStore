using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "miguelpz@gmail.com";
        public string MailFromAddress = "tienda@sport.com";
        public bool UseSsl = true;
        public string Username = "miguelpz@gmail.com";
        public string Password = "***********";
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
        public bool WriteAsFile = false;
        public string FileLocation = @"c:\sports_store_emails";
    }
}
