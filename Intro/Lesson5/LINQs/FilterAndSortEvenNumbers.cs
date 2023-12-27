using System;
using System.Collections.Generic;
using System.Linq;

namespace Intro.Lesson5.LINQs
{

    //Given a list of integers, write a C# program that uses LINQ to perform the following tasks:
    //Filter out even numbers from the list. Sort the remaining numbers in ascending order.Display the sorted numbers.
    internal class FilterAndSortEvenNumbers
    {
        /// <summary>
        /// Fills the List of integers with random numbers (1; 10000), by a given number of integers.
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        public static List<int> FillRandomNumers(int limit) {
            List<int> numbers = new List<int>();
            Random random = new Random();

            for (int i = 0; i < limit; i++) {
                numbers.Add(random.Next(1, 10000));
            }
            return numbers;
        }

        /// <summary>
        /// Filters even numbers from the list and sorts the remaining numbers in ascending order.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<int> FilterAndSort(List<int> list) {

            // another aproach
            //var filteredAndSortedNumbers = from number in list
            //             where number % 2 == 0 
            //             orderby number
            //             select number;

            List<int> filteredAndSortedNumbers = list
                .Where(num => num % 2 == 0)
                .OrderBy(num => num)
                .ToList();

            return filteredAndSortedNumbers;
        }

        /// <summary>
        /// Prints the given integer list.
        /// </summary>
        /// <param name="list"></param>
        public static void PrintList(List<int> list) {
            int index = 0;
            foreach (int num in list) {
                if (index == 0) {
                    Console.Write("[" + num + ", ");
                    index++;
                }
                else if (index == list.Count - 1) {
                    Console.Write(num + "]");
                    index++;
                }
                else {
                    Console.Write(num + ", ");
                    index++;
                }
            }
        }
    }
}