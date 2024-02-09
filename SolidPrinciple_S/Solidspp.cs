using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple_S
{
    public class Solidspp
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Solidspp(string Name, string Email)
        {
            this.Name = Name;
            this.Email = Email;
        }
        public void Register()
        {
            
            Console.WriteLine("User " + Name + " registered successfully.");
            EmailSender.SendEmail(Email, "Join the meeting.");
        }
    }

    public class EmailSender
    {
        public static void SendEmail(string to, string message)
        {
            
            Console.WriteLine("Sending mail to "+ to +" : " + message);
        }
    }


}
