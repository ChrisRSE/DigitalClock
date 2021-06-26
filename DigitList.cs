using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalClock
{
    class DigitList
    {
        const int height = 7;
        const int width = 6;
        List<Digit> digits = new List<Digit>();
        char[,] digit;

        /*            //Digit Two
            digit = new char[height, width]
            {
            {' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' '},};
            AddDigitToList(digits, digit);
        */

        public DigitList()
        {
            //Digit Zero
            digit = new char[height, width]
            {
            {'#','#','#','#','#','#'},
            {'#',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#'},
            {'#','#','#','#','#','#'},};
            AddDigitToList(Digits, digit);

            //Digit One
            digit = new char[height, width]
            {
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},};
            AddDigitToList(Digits, digit);

            //Digit Two
            digit = new char[height, width]
            {
            {'#','#','#','#','#','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},
            {'#','#','#','#','#','#'},
            {'#',' ',' ',' ',' ',' '},
            {'#',' ',' ',' ',' ',' '},
            {'#','#','#','#','#','#'},};
            AddDigitToList(Digits, digit);

            //Digit Three
            digit = new char[height, width]
            {
            {'#','#','#','#','#','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},
            {'#','#','#','#','#','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},
            {'#','#','#','#','#','#'},};
            AddDigitToList(Digits, digit);

            //Digit Four
            digit = new char[height, width]
            {
            {'#',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#'},
            {'#','#','#','#','#','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},};
            AddDigitToList(Digits, digit);

            //Digit Five
            digit = new char[height, width]
            {
            {'#','#','#','#','#','#'},
            {'#',' ',' ',' ',' ',' '},
            {'#',' ',' ',' ',' ',' '},
            {'#','#','#','#','#','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},
            {'#','#','#','#','#','#'},};
            AddDigitToList(Digits, digit);

            //Digit Six
            digit = new char[height, width]
            {
            {'#','#','#','#','#','#'},
            {'#',' ',' ',' ',' ',' '},
            {'#',' ',' ',' ',' ',' '},
            {'#','#','#','#','#','#'},
            {'#',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#'},
            {'#','#','#','#','#','#'},};
            AddDigitToList(Digits, digit);

            //Digit Seven
            digit = new char[height, width]
            {
            {'#','#','#','#','#','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},};
            AddDigitToList(Digits, digit);

            //Digit Eight
            digit = new char[height, width]
            {
            {'#','#','#','#','#','#'},
            {'#',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#'},
            {'#','#','#','#','#','#'},
            {'#',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#'},
            {'#','#','#','#','#','#'},};
            AddDigitToList(Digits, digit);

            //Digit Nine
            digit = new char[height, width]
            {
            {'#','#','#','#','#','#'},
            {'#',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ','#'},
            {'#','#','#','#','#','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},
            {' ',' ',' ',' ',' ','#'},};
            AddDigitToList(Digits, digit);
        }

        public List<Digit> Digits { get => digits;}

        private void AddDigitToList(List<Digit> list, char[,] digitArr)
        {
            Digit digit = new Digit(digitArr);
            list.Add(digit);
        }
    }
}
