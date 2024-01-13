using System.Diagnostics;

#pragma warning disable CS8602
namespace GenericOperationsUtility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICalculationUtility<double> numericCalculator = new NumericCalculationUtils();
            double num1 = 10;
            double num2 = 3;

            Console.WriteLine($"Numeric Addition: {numericCalculator.Add(num1, num2)}");
            Console.WriteLine($"Numeric Subtraction: {numericCalculator.Subtract(num1, num2)}");
            Console.WriteLine($"Numeric Multiplication: {numericCalculator.Multiply(num1, num2)}");

            double quotient = numericCalculator.Divide(num1, num2, out double remainder);
            Console.WriteLine($"Numeric Division: Quotient = {quotient}, Remainder = {remainder}");

            ICalculationUtility<string> stringCalculator = new StringCalculationUtils();
            string strA = "String";
            string strB = "Calculation";

            Console.WriteLine($"String Addition: {stringCalculator.Add(strA, strB)}");

            try {
                Console.WriteLine($"String Subtraction: {stringCalculator.Subtract(strA, strB)}");
                Console.WriteLine($"String Multiplication: {stringCalculator.Multiply(strA, strB)}");

                string result = stringCalculator.Divide(strA, strB, out string remainderStr);
                Console.WriteLine($"String Division: Quotient = {result}, Remainder = {remainderStr}");
            }
            catch (Exception ex) {
                Console.WriteLine(GetFormattedExceptionDetails(ex));
            }
        }

        /// <summary>
        /// Retrieves a formatted exception message containing class, method, and error details.
        /// </summary>
        /// <param name="exception">The exception for which to retrieve the class name, method name and error message.</param>
        /// <returns>
        /// A string containing information about the class, method, and error message of the provided exception.
        /// </returns>
        /// <remarks>
        /// This method creates a formatted exception message including the class name, method name, and the error message
        /// from the specified exception object.
        /// </remarks>
        /// <param name="exception">The exception for which to retrieve the message.</param>
        public static string GetFormattedExceptionDetails(Exception exception)
        {

            var trace = new StackTrace(exception, true);
            var className = Path.GetFileNameWithoutExtension(trace.GetFrame(0).GetFileName());
            string? methodName = trace.GetFrame(0).GetMethod().Name;

            return $"Class: {className} | Method: {methodName} | Error Message: {exception.Message}";
        }
    }
}
