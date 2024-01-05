using System;

namespace Advanced.Lesson1.GenericOperationsUtility
{
    public interface ICalculationUtility<T>
    {
        T Add(T value1, T value2);
        T Subtract(T value1, T value2);
        T Multiply(T value1, T value2);
        T Divide(T value1, T value2, out T reminder);
    }
}
