using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Anagram
    {
        public string a;
        public string b;
        public void PrintText()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------- Anagram Section ----------------------------------");
            Console.Write("Enter word 1 = ");
            a = Console.ReadLine();
            Console.Write("Enter word 2 = ");
            b = Console.ReadLine();
        }

        public static bool AreAnagrams(string a, string b)
        {
            int count1, count2;
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    count1 = 0;
                    count2 = 0;
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (a[i] == b[j])
                            count1++;
                        if (a[i] == a[j])
                            count2++;
                    }
                    if (count1 != count2)
                        return false;
                }
                return true;
            }
            else
                return false;
        }
    }
}
