using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Lesson5.LINQs
{

    //Given a list of orders(OrderId, CustomerName) with customer information,
    //write a C# program that uses LINQ to perform the following tasks:
    //Group the orders by the customer.Count the number of orders for each customer.
    //Display the customer name and the count of orders.
    internal class OrdersMain
    {
        public static void Main(string[] args) {
            List<Order> orders = new List<Order>() {
            new Order("Bob", 101),
            new Order("Charlie", 202),
            new Order("Sam", 101),
            new Order("Ammy", 202),
            new Order("Jack", 505),
            new Order("Liem", 707),
            new Order("Lior", 303)
        };

            // cannot access 'CustomerName' & 'OrderCount' for printing
            //var groupedOrdersByCustomer = Order.GroupOrdersByCustomer(orders);

            var groupedOrdersByCustomer = from order in orders
                                          group order by order.CustomerName into groupedOrders
                                          select new {
                                              CustomerName = groupedOrders.Key,
                                              OrderCount = groupedOrders.Count()
                                          };

            Console.WriteLine("Customer Orders:");
            foreach (var order in groupedOrdersByCustomer) {
                Console.WriteLine($"Customer: {order.CustomerName}, Order Count: {order.OrderCount}");
            }
        }
    }
}