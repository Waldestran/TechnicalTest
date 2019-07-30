using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class StringCompression
    {
        string word;
        public void PrintText()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------- string compression Method ----------------------------------");
            Console.Write("Enter word = ");
            word = Console.ReadLine();
        }

        public string BasicCompression()
        {
            string compressedWord = "";
            int count = 1;
            int j = 0;

            for (int i = 0; i < word.Length; i++)
            {
                j = j + 1;

                if (j < word.Length)
                {
                    if (word[i] == word[j])
                        count++;
                    else
                    {
                        if (count > 1)
                            compressedWord = compressedWord + word[i] + count.ToString();                         
                        else
                            compressedWord = compressedWord + word[i];                        
                        count = 1;
                    }
                }
                else
                {
                    if (count > 1)
                        compressedWord = compressedWord + word[i] + count.ToString();
                    else
                        compressedWord = compressedWord + word[i];
                    count = 1;
                }
            }

            if (compressedWord.Length < word.Length)
                return compressedWord;
            else
                return word;
        }
    }
}
