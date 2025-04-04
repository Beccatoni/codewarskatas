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
    }
}