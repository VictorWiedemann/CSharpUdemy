using System;

namespace CSharpUdemy
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending Mail");
        }
    }
}