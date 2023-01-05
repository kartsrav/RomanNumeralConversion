using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeral
{
    public static class RomanNumeralConverter
    {

        private static readonly Dictionary<int, string> _numerals = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };
        /// <summary>
        /// Explanation :This solution defines a RomanNumeralConverter class with a ConvertToRomanNumeral method that takes an integer as an argument and returns the corresponding Roman numeral. The method first checks that the number is between 1 and 2000, and throws an exception if it is not.
        /// Then, the method uses a dictionary to store the mapping of decimal values to Roman numerals, and iterates over the dictionary, adding the corresponding Roman numeral to the result string for each decimal value that is less than or equal to the number being converted.
        /// Finally, the method returns the result string.
        /// </summary>
        public static string ConvertToRomanNumeral(int number)
        {
            if (number < 1 || number > 2000)
            {
                throw new ArgumentOutOfRangeException("number", "Number must be between 1 and 2000");
            }

            string romanNumeral = "";

            foreach (var numeral in _numerals)
            {
                while (number >= numeral.Key)
                {
                    romanNumeral += numeral.Value;
                    number -= numeral.Key;
                }
            }

            return romanNumeral;
        }
    }
}
