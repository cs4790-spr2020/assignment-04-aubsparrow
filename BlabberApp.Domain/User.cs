using System;
using System.Net.Mail;
using BlabberApp.Domain;

namespace BlabberApp.Domain
{
    public class User : BaseDatum
    {
        public DateTime RegisterDTTM{get; set;}
        public DateTime LastLoginDTTM{get; set;}
        public string Email {get; private set;}

        public void ChangeEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || email.Length > 50)
                throw new FormatException("Email Invalid");
            try
            {
                MailAddress m = new MailAddress(email); 
            }
            catch (FormatException)
            {
                throw new FormatException("Email Invalid");
            }
            Email = email;
        }
    }

}