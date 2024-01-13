using System;

namespace OnlineShoppingSystem.Helpers
{
    public delegate double DiscountCalculator(double totalAmount);
    public class Discounter
    {
        public static double RegularCustomerDiscount(double totalAmount) {
            double discountPercentage = 5;
            return totalAmount * (1 - discountPercentage / 100);
        }

        public static double VIPCustomerDiscount(double totalAmount) {
            double discountPercentage = 10;
            return totalAmount * (1 - discountPercentage / 100);
        }

        public static double SaleDiscount(double totalAmount) {
            double discountPercentage = 15;
            return totalAmount * (1 - discountPercentage / 100);
        }
    }
}