using System;

namespace CSharpUdemy
{
    public class Stopwatch
    {
        public DateTime TrackingTime { get; set; }
        private bool IsStarted { get; set; }

        public Stopwatch()
        {
            IsStarted = false;
        }

        public void StartTime()
        {
            if (IsStarted == true)
            {
                throw new InvalidOperationException();
            }

            IsStarted = true;
            TrackingTime = DateTime.Now;
        }

        public void ReadTime()
        {
            var currTime= new DateTime();
            currTime = DateTime.Now;
            var value = TrackingTime - DateTime.Now;
            Console.WriteLine(value);
            
        }

        public void ResetTime()
        {
            IsStarted = false;
        }
    }
}