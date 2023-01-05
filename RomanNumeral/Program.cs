using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 123;
            string romanNumeral = RomanNumeralConverter.ConvertToRomanNumeral(number);
            Console.WriteLine(romanNumeral); // Output: CXXIII
            Console.ReadKey();
        }
    }
}
