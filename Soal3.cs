using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutaGenerasiMandiriTest
{
    class Soal3
    {
        public static void main()
        {
            Console.Write("Input : ");
            string input = Console.ReadLine();
            SortedDictionary<char, int> letterCounts = CountAndSortLetters(input.Replace(" ", ""));

            Console.WriteLine("Output:");

            string result = "";
            foreach (var kvp in letterCounts)
            {
                result = result + $"'{kvp.Key}': {kvp.Value}, ";
            }
            Console.WriteLine("[" + result + "]");
        }

        static SortedDictionary<char, int> CountAndSortLetters(string input)
        {
            Dictionary<char, int> letterCounts = new Dictionary<char, int>();

            foreach (char letter in input)
            {
                if (letterCounts.ContainsKey(letter))
                    letterCounts[letter]++;
                else
                    letterCounts[letter] = 1;
            }

            SortedDictionary<char, int> sortedDictionary = new SortedDictionary<char, int>(letterCounts);

            return sortedDictionary;
        }
    }
}
