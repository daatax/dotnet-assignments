using System;

namespace Intro.Lesson4.MathOperations
{
    internal class MathHelperMain
    {
        public static void Main(string[] args) {
            Console.WriteLine("The PI value is: " + MathHelper.PI);
            Console.WriteLine("A Random generated number: " + +MathHelper.GetRandomValue());
            Console.WriteLine("A square root of the random generated number is: " + MathHelper.SquareRoot(MathHelper.GetRandomValue()));
            Console.WriteLine(MathHelper.Exponentiation(12, 3));
            Console.WriteLine();

            if (MathHelper.IsInputNumberValid("Please enter a valid number ...", out double num1)
                && MathHelper.IsInputNumberValid("Please enter a valid number ...", out double num2)) {
                MathHelper.GetInputOperation("What operation you want to perform? Possible operations are - /addition, subtraction, multiplication, division/", out string operation);

                if (operation == "division" && num1 == 0 || num2 == 0) {
                    Console.WriteLine("Cannot Divide by 0.");
                }
                else {
                    MathHelper.PrintResult(num1, num2, operation);
                }
            }
            else {
                Console.WriteLine("Please enter a VALID number.");
            }
        }
    }
}