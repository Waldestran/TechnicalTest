using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class RomanNumeral
    {
        int number;
        public void PrintText()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------- Integer number to Roman Numeral ----------------------------------");
            Console.Write("Enter integer number = ");
            number = int.Parse(Console.ReadLine());
        }

        public string ConvertToRoman()
        {
            int Thousands, Rest, Hundreds, Tens, Units;
            string nConv;

            nConv = "";

            if (number < 4000)
            {
                Thousands = number / 1000;
                Rest = number % 1000;
                Hundreds = Rest / 100;
                Rest = Rest % 100;
                Tens = Rest / 10;
                Units = Rest % 10;

                switch (Thousands)
                {
                    case 1:
                        nConv = "M";
                        break;

                    case 2:
                        nConv = "MM";
                        break;

                    case 3:
                        nConv = "MMM";
                        break;
                }

                switch (Hundreds)
                {
                    case 1:
                        nConv = nConv + "C";
                        break;

                    case 2:
                        nConv = nConv + "CC";
                        break;

                    case 3:
                        nConv = nConv + "CCC";
                        break;

                    case 4:
                        nConv = nConv + "CD";
                        break;

                    case 5:
                        nConv = nConv + "D";
                        break;

                    case 6:
                        nConv = nConv + "DC";
                        break;

                    case 7:
                        nConv = nConv + "DCC";
                        break;

                    case 8:
                        nConv = nConv + "DCCC";
                        break;

                    case 9:
                        nConv = nConv + "CM";
                        break;
                }

                switch (Tens)
                {
                    case 1:
                        nConv = nConv + "X";
                        break;

                    case 2:
                        nConv = nConv + "XX";
                        break;

                    case 3:
                        nConv = nConv + "XXX";
                        break;

                    case 4:
                        nConv = nConv + "XL";
                        break;

                    case 5:
                        nConv = nConv + "L";
                        break;

                    case 6:
                        nConv = nConv + "LX";
                        break;

                    case 7:
                        nConv = nConv + "LXX";
                        break;

                    case 8:
                        nConv = nConv + "LXXX";
                        break;

                    case 9:
                        nConv = nConv + "XC";
                        break;
                }

                switch (Units)
                {
                    case 1:
                        nConv = nConv + "I";
                        break;

                    case 2:
                        nConv = nConv + "II";
                        break;

                    case 3:
                        nConv = nConv + "III";
                        break;

                    case 4:
                        nConv = nConv + "IV";
                        break;

                    case 5:
                        nConv = nConv + "V";
                        break;

                    case 6:
                        nConv = nConv + "VI";
                        break;

                    case 7:
                        nConv = nConv + "VII";
                        break;

                    case 8:
                        nConv = nConv + "VIII";
                        break;

                    case 9:
                        nConv = nConv + "IX";
                        break;
                }
            }
            else
            {
                nConv = "The number should be less than 4000";
            }

            return nConv;
        }
    }
}
