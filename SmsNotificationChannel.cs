using System;

namespace CSharpUdemy
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("sending SMS");
        }
    }
}