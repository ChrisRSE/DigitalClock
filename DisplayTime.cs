using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClock
{
    class DisplayTime
    {
        String time;
        public void RefreshTime()
        {
            TimeToString();
            Console.Clear();
            Console.WriteLine(time);
            Delay(1);
        }

        private void TimeToString()
        {
            time = DateTime.Now.ToString("h:mm:ss");
        }

        private void Delay(int seconds)
        {
            System.Threading.Thread.Sleep(seconds * 1000);
        }
    }
}
