using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClock
{
    class Digit
    {
        readonly char[,] _layout;

        public Digit(int height, int width)
        {
            _layout = new char[height, width];
        }
    }
}
