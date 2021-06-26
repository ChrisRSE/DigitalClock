using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClock
{
    class DisplayTime
    {
        private char[] time;
        private int[] hour = new int[2];
        private int[] min = new int[2];
        private int[] sec = new int[2];
        private Face face = new Face();
        private DigitList digitList = new DigitList();

        public void RefreshTime()
        {
            Console.Clear();
            face.ResetBoard();
            TimeToInt();
            SetTime();
            face.PrintBoard();
            Delay(1000);
        }

        public void TimeToInt()
        {
            time = DateTime.Now.ToLongTimeString().ToCharArray();
            hour[0] = time[0] - '0';
            hour[1] = time[1] - '0';
            min[0] = time[3] - '0';
            min[1] = time[4] - '0';
            sec[0] = time[6] - '0';
            sec[1] = time[7] - '0';
        }

        private void Delay(int milliseconds)
        {
            System.Threading.Thread.Sleep(milliseconds);
        }

        private void SetTime()
        {
            UpdateTime(digitList.Digits[hour[0]], 1);
            UpdateTime(digitList.Digits[hour[1]], 2);
            UpdateTime(digitList.Digits[min[0]], 3);
            UpdateTime(digitList.Digits[min[1]], 4);
            UpdateTime(digitList.Digits[sec[0]], 5);
            UpdateTime(digitList.Digits[sec[1]], 6);
        }

        private void UpdateTime(Digit digit, int position)
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
