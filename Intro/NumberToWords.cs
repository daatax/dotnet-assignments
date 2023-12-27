using System;

namespace Intro
{
    public class NumberToWords
    {
        public static void Main(string[] args) {
            string words = ConvertToWords(942);
        }

        static string[] oneToNineteen = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        static string[] tens = new string[] { "", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };

        static string[] thousands = new string[] { "", "Thousand", "Million", "Billion" };

        public static string ConvertToWords(int inputNumber) {

            if (inputNumber < 0) {
                throw new ArgumentOutOfRangeException("Input number should be positive");
            }

            if (inputNumber < 20) {
                return oneToNineteen[inputNumber];
            }

            if (inputNumber < 100) {
                return tens[inputNumber / 10] + " " + ConvertToWords(inputNumber % 10);
            }

            if (inputNumber < 1000) {
                return ConvertToWords(inputNumber / 100) + " Hundred " + ConvertToWords(inputNumber % 100);
            }

            // more than 1000s
            // 10321 - Ten Thousand Three Hundred Twenty One


            return "";
        }

    }
}