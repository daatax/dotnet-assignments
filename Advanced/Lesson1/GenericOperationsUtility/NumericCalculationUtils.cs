namespace GenericOperationsUtility
{
    public class NumericCalculationUtils : ICalculationUtility<double>
    {
        public double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        public double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }

        public double Subtract(double value1, double value2)
        {
            return value1 - value2;
        }

        public double Divide(double value1, double value2, out double reminder)
        {
            reminder = value1 % value2;
            return value1 / value2;
        }
    }
}
