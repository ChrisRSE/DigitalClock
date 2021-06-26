using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClock
{
    class DisplayTime
    {
        String time;
        Face face = new Face();
        DigitList digitList = new DigitList();

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

        public void PrintTest()
        {
            face.PrintBoard();
        }

        public void UpdateTime(Digit digit, int position)
        {
            int offset = 0;
            for(int i = 0; i < digitList.Height; i++)
            {
                for(int j = 0; j < digitList.Width; j++)
                {
                    if(digit.Layout[i,j] == '#')
                    {
                        if (position == 1)
                        {
                            offset = 3;
                        }
                        if (position == 2)
                        {
                            offset = 11;
                        }
                        if (position == 3)
                        {
                            offset = 22;
                        }
                        if (position == 4)
                        {
                            offset = 30;
                        }
                        if (position == 5)
                        {
                            offset = 41;
                        }
                        if (position == 6)
                        {
                            offset = 49;
                        }
                        face.ChangeChar(i, j, offset);
                    }
                }
            }
        }
    }
}
