using System;
using System.Collections.Generic;

namespace DigitalClock
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayTime displayTime = new DisplayTime();
            DigitList digitList = new DigitList();

            while(true)
            {
                displayTime.RefreshTime();
            }

        }



    }
}
