using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClock
{
    class Digit
    {
        readonly char[,] _layout;

        public Digit()
        {
            _layout = new char[7, 6];
        }
    }
}
