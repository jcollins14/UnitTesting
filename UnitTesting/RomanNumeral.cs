using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    class RomanNumeral
    {
        public string Convert(int input)
        {
            string output = "";
            while (input >= 1000)
            {
                if (input % 1000 == 0 || input / 1000 >= 1)
                {
                    output += "M";
                    input -= 1000;
                }
            }
            //if (input >= 990)
            //{
            //    output += "XM";
            //    input -= 990;
            //}
            //if (input >= 950)
            //{
            //    output += "LM";
            //    input -= 950;
            //}
            if (input >= 900 )
            {
                output += "CM";
                input -= 900;
            }
            while (input >= 500)
            {
                if (input % 500 == 0 || input / 500 >= 1)
                {
                    output += "D";
                    input -= 500;
                }
            }
            //if (input >= 490)
            //{
            //    output += "XD";
            //    input -= 490;
            //}
            //if (input >= 450)
            //{
            //    output += "LD";
            //    input -= 450;
            //}
            if (input >= 400)
            {
                output += "CD";
                input -= 400;
            }
            while (input >= 100)
            {
                if (input % 100 == 0 || input / 100 >= 1)
                {
                    output += "C";
                    input -= 100;
                }
            }
            if (input >= 90)
            {
                output += "XC";
                input -= 90;
            }
            while (input >= 50)
            {
                if (input % 50 == 0 || input / 50 >= 1)
                {
                    output += "L";
                    input -= 50;
                }
            }
            if (input >= 40)
            {
                output += "XL";
                input -= 40;
            }
            while (input >= 10)
            {
                if (input % 10 == 0 || input / 10 >= 1)
                {
                    output += "X";
                    input -= 10;
                }
            }
            if (input == 9)
            {
                output += "IX";
                input -= 9;
            }
            while (input >= 5)
            {
                if (input % 5 == 0 || input / 5 >= 1)
                {
                    output += "V";
                    input -= 5;
                }
            }
            if (input == 4)
            {
                output += "IV";
            }
            while (input < 4 && input != 0)
            {
                output += "I";
                input--;
            }
            return output;
        }
    }
}
