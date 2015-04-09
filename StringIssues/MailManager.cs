using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIssues
{
    class MailManager
    {
        private class EmailDispatcher
        {
            public void Send(string address, string body){}
        }
        public class Subscriber
        {
            public string FirstName { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string EmailAddress { get; set; }
        }

        private readonly EmailDispatcher emailDispatcher = new EmailDispatcher();

        public void SendPaswordRecoveryMail(List<Subscriber> subscribers)
        {
            String emailBody = "";

            for (int i = 0; i < subscribers.Count; i++)
            {
                emailBody += "Hello " + subscribers[i].FirstName + ",";
                emailBody += "this is a reminder with your account information: "+Environment.NewLine + Environment.NewLine;
                emailBody += "Your username: " + subscribers[i].Username + Environment.NewLine;
                emailBody += "Your password: " + subscribers[i].Password + Environment.NewLine;
                emailBody += "Have a great day!";

                emailDispatcher.Send(subscribers[i].EmailAddress, emailBody);
            }

        }
    }
}
