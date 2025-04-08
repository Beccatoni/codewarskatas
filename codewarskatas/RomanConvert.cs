namespace codewarskatas
{
    public class RomanConvert
    {
        public static string Solution(int number)
        {
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] hundreds = {"", "C", "CC", "CCC", "CD", "D", "DCC", "DCCC", "CM"};
            string[] thousands = { "", "M", "MM", "MMM" };
            
            return thousands[number/1000] + hundreds[(number % 1000)/100] + tens[(number % 100)/10] + ones[number % 10];
        }
    }
}