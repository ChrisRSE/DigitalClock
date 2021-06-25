using System;
using System.Collections.Generic;

namespace DigitalClock
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayTime displayTime = new DisplayTime();

            //Console.WriteLine("19:40:21");
            //Console.WriteLine("19:40:22");
            //Console.WriteLine("19:40:23");

            /*for (int i = 0; i < 60; i++)
            {
                displayTime.RefreshTime();
            }*/

            char[] myArray = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '=' };

            Console.WriteLine("Test");

            //first number
            int i = 0;
            int j = 6;
            myArray[i+1] = '#';
            myArray[i+2] = '#';
            myArray[i+3] = '#';
            myArray[i+4] = '#';

            myArray[j + 1] = '#';
            myArray[j + 2] = '#';
            myArray[j + 3] = '#';
            myArray[j + 4] = '#';

            foreach (var letter in myArray)
            {
                Console.Write(letter);
            }
        }
    }
}
