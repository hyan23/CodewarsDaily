using System;
using System.Collections.Generic;
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

        // https://www.codewars.com/kata/56606694ec01347ce800001b/train/csharp
        public static bool IsTriangle(int a, int b, int c)
        {
            if (a + b > c && Math.Abs(a - b) < c ||
                a + c > b && Math.Abs(a - c) < b ||
                b + c > a && Math.Abs(b - c) < a)
            {
                return true;
            }
            return false;
        }

        public static void TestIsTriangle()
        {
            System.Console.WriteLine(IsTriangle(5, 7, 10));
        }

        // https://www.codewars.com/kata/consecutive-strings/train/csharp
        public static String LongestConsec(string[] strarr, int k)
        {
            if (strarr.Length == 0 || k > strarr.Length || k <= 0)
            {
                return "";
            }
            int length = 0;
            int maxLength = 0;
            int minIndex = 0;
            for (int i = 0; i < strarr.Length; i++)
            {
                length += strarr[i].Length;
                if (i >= k)
                {
                    length -= strarr[i - k].Length;
                }
                if (length > maxLength)
                {
                    maxLength = length;
                    minIndex = i - k + 1;
                }
            }
            return string.Join("", strarr.Skip(minIndex).Take(k));
        }

        public static void TestLongestConsec()
        {
            System.Console.WriteLine(LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2));
            System.Console.WriteLine(LongestConsec(new String[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1));
            System.Console.WriteLine(LongestConsec(new String[] { }, 3));
            System.Console.WriteLine(LongestConsec(new String[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2));
        }

        // https://www.codewars.com/kata/523a86aa4230ebb5420001e1/train/csharp
        public static List<string> Anagrams(string word, List<string> words)
        {
            /*
            List<string> lst = new List<string>();
            HashSet<char> s1 = new HashSet<char>(word);
            foreach (var w in words)
            {
                HashSet<char> s2 = new HashSet<char>(w);
                if (s1.IsSubsetOf(s2) && s2.IsSubsetOf(s1))
                {
                    lst.Add(w);
                }
            }
            return lst;
            */

            List<string> lst = new List<string>();
            List<char> chList = new List<char>(word);
            chList.Sort();
            string sorted = string.Join("", chList);
            foreach (var w in words)
            {
                chList = new List<char>(w);
                chList.Sort();
                if (string.Join("", chList) == sorted)
                {
                    lst.Add(w);
                }
            }
            return lst;
        }

        public static void TestAnagrams()
        {
            Anagrams("a", new List<string> { "a", "b", "c", "d" }).ForEach(x => System.Console.WriteLine(x));
            Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }).ForEach(x => System.Console.WriteLine(x));
        }
    }
}
