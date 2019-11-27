using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoFacDependencyInjection.Services
{
    public class MailService : IMailService
    {
        public string CheckedMail(string mail)
        {
            var email = new EmailAddressAttribute();
            return new EmailAddressAttribute().IsValid(mail) ? "Geçerli" : "Geçersiz";
        }
    }
}