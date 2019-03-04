using System;
using System.Linq;

namespace CodeWarsDaily
{
    public class Kata
    {
        // https://www.codewars.com/kata/replace-with-alphabet-position
        public static string AlphabetPosition(string text)
        {

            string result = "";
            foreach (var ch in text.ToLower())
            {
                if (char.IsLower(ch))
                {
                    result += (ch - 'a' + 1) + " ";
                }
            }
            return result.TrimEnd();
        }

        public static void TestAlphabetPosition()
        {
            System.Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));
        }

        // https://www.codewars.com/kata/counting-duplicates/train/csharp
        public static int DuplicateCount(string str)
        {
            int[] chCount = new int[128];
            foreach (var ch in str.ToLower())
            {
                chCount[ch]++;
            }
            return chCount.Count(x => x > 1);
        }

        public static void TestDuplicateCount()
        {
            System.Console.WriteLine(DuplicateCount(""));
            System.Console.WriteLine(DuplicateCount("abcde"));
            System.Console.WriteLine(DuplicateCount("aabbcde"));
            System.Console.WriteLine(DuplicateCount("aabBcde"));
            System.Console.WriteLine(DuplicateCount("Indivisibility"));
            System.Console.WriteLine(DuplicateCount("Indivisibilities"));
        }
    }
}
