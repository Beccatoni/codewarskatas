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
    }
}
