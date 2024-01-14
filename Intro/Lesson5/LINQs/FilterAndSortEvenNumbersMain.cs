using System;
using System.Collections.Generic;
using System.Linq;

namespace Intro.Lesson5.LINQs
{

    //Given a list of integers, write a C# program that uses LINQ to perform the following tasks:
    //Filter out even numbers from the list. Sort the remaining numbers in ascending order.Display the sorted numbers.
    internal class FilterAndSortEvenNumbersMain
    {
        public static void Main(string[] args) {
            List<int> numbers = FilterAndSortEvenNumbers.FillRandomNumers(30);

            Console.WriteLine("The original List of numbers");
            FilterAndSortEvenNumbers.PrintList(numbers);
            Console.WriteLine();

            Console.WriteLine("Filtered and sorted List of even numbers");
            List<int> filteredAndSorted = FilterAndSortEvenNumbers.FilterAndSort(numbers);
            FilterAndSortEvenNumbers.PrintList(filteredAndSorted);
        }
    }
}