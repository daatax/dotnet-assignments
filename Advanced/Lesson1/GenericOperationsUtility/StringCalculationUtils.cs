namespace GenericOperationsUtility
{
    public class StringCalculationUtils : ICalculationUtility<string>
    {
        public string Add(string value1, string value2)
        {
            return value1 + value2;
        }

        public string Subtract(string value1, string value2)
        {
            if (value1.Contains(value2)) {
                return value1.Replace(value2, string.Empty);
            }
            throw new InvalidOperationException("Cannot subtract strings. Substring cannot be found.");
        }

        public string Multiply(string value1, string value2)
        {
            throw new Exception("Multiplication is not supported for strings.");
        }

        public string Divide(string value1, string value2, out string remainder)
        {
            throw new Exception("Division is not supported for strings.");
        }
    }
}
