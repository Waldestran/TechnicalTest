using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            int option = 1;
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*********************** Menu ************************");
            Console.WriteLine("*** Instructions: Enter the option number choosed ***");
            Console.WriteLine("*** 1. Calculate the Sigma Serie                  ***");
            Console.WriteLine("*** 2. Calculate the Angle of the Analog Clock    ***");
            Console.WriteLine("*** 3. Verify if two words are anagrams           ***");
            Console.WriteLine("*** 4. Basic String Compression                   ***");
            Console.WriteLine("*** 5. Convert Integer to Roman numeral           ***");
            Console.WriteLine("*** 0. End program                                ***");
            option = int.Parse(Console.ReadLine());

            while (option != 0)
            {             
                switch (option)
                {
                    case 1:
                        SigmaSerie Expression = new SigmaSerie();
                        Expression.InputValues();
                        Console.WriteLine("The result is: " + Expression.CalculateExpression());
                        Console.WriteLine("");
                        Console.WriteLine("Enter option number or 0 to exit");
                        option = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        AnalogClock Clock = new AnalogClock();
                        Clock.PrintText();
                        Console.WriteLine("The Result with turn clockwise is: " + Clock.CalculateAngleRight());
                        Console.WriteLine("The Result with the opposite turn clockwise is: " + Clock.CalculateAngleLefth());
                        Console.WriteLine("");
                        Console.WriteLine("Enter option number or 0 to exit");
                        option = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Anagram _Anagram = new Anagram();
                        _Anagram.PrintText();
                        Console.WriteLine("Are it anagrams? " + Anagram.AreAnagrams(_Anagram.a, _Anagram.b));
                        Console.WriteLine("");
                        Console.WriteLine("Enter option number or 0 to exit");
                        option = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        StringCompression Word = new StringCompression();
                        Word.PrintText();
                        Console.WriteLine("The word compressed is: " + Word.BasicCompression());
                        Console.WriteLine("");
                        Console.WriteLine("Enter option number or 0 to exit");
                        option = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        RomanNumeral Roman = new RomanNumeral();
                        Roman.PrintText();
                        Console.WriteLine("Roman number is: " + Roman.ConvertToRoman());
                        Console.WriteLine("");
                        Console.WriteLine("Enter option number or 0 to exit");
                        option = int.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }            
        }
    }
}
