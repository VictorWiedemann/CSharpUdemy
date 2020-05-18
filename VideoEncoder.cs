using System.Collections;
using System.Collections.Generic;
using System.Net.Http;

namespace CSharpUdemy
{
    public class VideoEncoder
    {

        private readonly IList<INotificationChannel> _notificationChannels;
        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode()
        {
            //some buisness logic here
            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}