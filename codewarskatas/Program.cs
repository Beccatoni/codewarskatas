using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewarskatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Becca God's daughter"));
            Console.WriteLine(BreakCamelCase("CSharpIsCool"));
            Console.WriteLine(NumberFormat(1232798537));
            Console.WriteLine(RomanToInt("MMVII"));
            Console.ReadLine();
        }

        static string ReverseString(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(new string(chars));
            return new string(chars);
        }

        static string BreakCamelCase(string str)
        {
            string result = "";
            foreach (char character in str)
            {
                if (char.IsUpper(character))
                {
                    result += " ";
                }
                result += character;
            }
            return result;
        }
        
        static string NumberFormat(int number)
        {
            return number.ToString("N0");
        }

        static int RomanToInt(string roman)
        {
            Dictionary<char, int> romanDict = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            int romanInt = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i > 0 && romanDict[roman[i]] > romanDict[roman[i - 1]])
                {
                    romanInt += romanDict[roman[i]] - 2 * romanDict[roman[i - 1]];
                }
                else
                {
                    romanInt += romanDict[roman[i]];
                }
            }


            return romanInt;
        }
    }
}
