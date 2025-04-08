using System.Collections.Generic;
using System.Linq;

namespace codewarskatas
{
    public class Kata
    {
        public static int Solution(int value)
        {
            // int sum = 0;
            // if (value <= 0) return 0;
            // for (int i = 0; i < value; i++)
            // {
            //     if ((i % 3 == 0) || (i % 5 == 0))
            //     {
            //         sum += i;
            //     }
            // }
            // return sum;
            
            //using linq
            return value <= 0 
                ? 0 
                : Enumerable.Range(0, value)
                    .Where(i => i % 3 == 0 || i % 5 == 0)
                    .Sum();
        }

        public static string Switcher(string[] x)
        {
            string result = "";
            Dictionary<int, string> dict = new Dictionary<int, string>
            {
                { 1, "z" }, { 2, "y" }, { 3, "x" }, { 4, "w" }, { 5, "v" },
                { 6, "u" }, { 7, "t" }, { 8, "s" }, { 9, "r" }, { 10, "q" },
                { 11, "p" }, { 12, "o" }, { 13, "n" }, { 14, "m" }, { 15, "l" },
                { 16, "k" }, { 17, "j" }, { 18, "i" }, { 19, "h" }, { 20, "g" },
                { 21, "f" }, { 22, "e" }, { 23, "d" }, { 24, "c" }, { 25, "b" },
                { 26, "a" }, { 27, "!" }, { 28, "?" }, { 29, " " }

            };

            foreach (var num in dict)
            {
                result += num.Value;
            }
            
            return result;
        }

        public static int VowelCounter(string str)
        {
            int vowelCount = 0; 
            string vowels = "aeiou";
            foreach (var ch in str)
            {
                if (vowels.Contains(ch))
                {
                    vowelCount++;
                }
            }
            
            return vowelCount;
        }
    }
}