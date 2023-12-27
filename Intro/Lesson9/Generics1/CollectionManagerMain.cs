using System;
using System.Collections.Generic;

namespace Intro.Lesson9.Generics1
{
    public class CollectionManagerMain
    {
        public static void Main(string[] args) {
            CollectionManager<int> intCollection = new CollectionManager<int>();
            CollectionManager<string> stringCollection = new CollectionManager<string>();

            intCollection.AddItem(11);
            intCollection.AddItem(45);
            intCollection.AddItem(56);
            intCollection.AddItem(72);

            stringCollection.AddItem("First string value");
            stringCollection.AddItem("Second string value");
            stringCollection.AddItem("Third string value");
            stringCollection.AddItem("Forth string value");

            intCollection.RemoveItem(45);
            // This will throw an exception
            //intCollection.RemoveItem(20);

            stringCollection.RemoveItem("Third string value");
            // This will throw an exception
            //stringCollection.RemoveItem("Another string value");

            Console.WriteLine("Items in the intCollection:");
            foreach (var item in intCollection.GetItems()) {
                Console.WriteLine(item);
            }

            Console.WriteLine("Items in int stringCollection:");
            foreach (var item in stringCollection.GetItems()) {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Number of items in the intCollection: {intCollection.CountItems()}");
            Console.WriteLine($"Number of items in the stringCollection: {stringCollection.CountItems()}");

            intCollection.ClearItems();
            stringCollection.ClearItems();

            Console.WriteLine($"Number of items in the intCollection after clearing: {intCollection.CountItems()}");
            Console.WriteLine($"Number of items in the stringCollection after clearing: {stringCollection.CountItems()}");
        }
    }
}