using System;
using System.Linq;
using System.Collections.Generic;

namespace Intro.Lesson10
{
    public class Program
    {

        public static void Main(string[] args) {
            List<int> list = new List<int>();

            for (int i = 0; i < 100; i++) {
                list.Add(i);
            }
            //object value = list.Where(null);

            var a = list.CustomWhere(x => x % 2 == 0);

            foreach (var item in a) {
                Console.WriteLine(item);
            }
        }

    }

}