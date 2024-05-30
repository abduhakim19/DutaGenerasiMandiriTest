using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutaGenerasiMandiriTest
{
    class Soal2
    {
        public static void main()
        {
            Console.Write("Input 1 : ");
            string input1 = Console.ReadLine();
            Console.Write("Pattern : ");
            string pattern = Console.ReadLine();

            int count1 = PatternCount(input1, pattern);
            Console.WriteLine("Output: " + count1); // Output: 1
        }

        static int PatternCount(string text, string pattern)
        {
            int count = 0;
            int textLength = text.Length;
            int patternLength = pattern.Length;

            for (int i = 0; i <= textLength - patternLength; i++)
            {
                bool match = true;
                for (int j = 0; j < patternLength; j++)
                {
                    if (text[i + j] != pattern[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    count++;
                }
            }

            return count;
        }

    }
}
