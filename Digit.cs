using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClock
{
    class Digit
    {
        readonly char[,] _layout;

        public Digit(char[,] layout)
        {
            _layout = layout;
        }

        public char[,] Layout => _layout;
    }
}
