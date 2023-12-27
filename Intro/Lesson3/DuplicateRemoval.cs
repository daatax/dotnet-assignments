using System;

namespace Intro.Lesson3
{
    internal class DuplicateRemoval
    {
        //Create a program that takes a list with duplicate values and produces a new array without any duplicates.
        public static void Main(String[] args) {
            List<int> duplicateNumbers = new List<int> { 12, 3, 45, 2, 12, 45 };
            Console.Write("The input list: ");
            PrintList(duplicateNumbers);
            Console.WriteLine();
            Console.Write("The list without duplicate values: ");
            PrintList(RemoveDuplicates(duplicateNumbers));
        }

        static List<int> RemoveDuplicates(List<int> duplicateNumbers) {
            List<int> uniqueNumbers = new List<int> { duplicateNumbers[0] };

            for (int i = 1; i < duplicateNumbers.Count; i++) {
                bool isDuplicated = false;

                for (int j = 0; j < uniqueNumbers.Count; j++) {
                    if (duplicateNumbers[i] == uniqueNumbers[j]) {
                        isDuplicated = true;
                        break;
                    }
                }
                if (!isDuplicated) {
                    uniqueNumbers.Add(duplicateNumbers[i]);
                }
            }

            return uniqueNumbers;
        }
        static void PrintList(List<int> list) {
            for (int i = 0; list.Count > i; i++) {
                if (i == 0) {
                    Console.Write("[ " + list[i] + "; ");
                }
                else if (i == list.Count - 1) {
                    Console.Write(list[i] + " ]");
                }
                else {
                    Console.Write(list[i] + "; ");
                }
            }
        }
    }
}