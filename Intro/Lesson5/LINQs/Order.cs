using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Intro.Lesson5.LINQs
{
    internal class Order
    {
        public string CustomerName { get; set; }
        public int OrderID { get; set; }

        public Order(string customerName, int orderID) {
            CustomerName = customerName;
            OrderID = orderID;
        }

        /// <summary>
        /// Groups the orders by the Customer Name and counts the number of orders.
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        public static IEnumerable GroupOrdersByCustomer(List<Order> orders) {

            var result = from order in orders
                         group order by order.CustomerName into groupedOrders
                         select new {
                             CustomerName = groupedOrders.Key,
                             OrderCount = groupedOrders.Count()
                         };

            return result;
        }

    }
}