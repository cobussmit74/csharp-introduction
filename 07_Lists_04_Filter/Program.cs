//DevFluence
//April 2019
//Course material: Intrucduction to C#

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Lists_04_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var theList = new List<int> { 5, 6, 7, 33, 44, 234, 55 };
            var limit = 100;

            var results1 = new List<int>();
            foreach (var item in theList)
            {
                if (item <= limit)
                {
                    results1.Add(item);
                }
            }

            Console.WriteLine($"Resuts 1");
            foreach (var item in results1)
            {
                Console.WriteLine(item);
            }


            var results2 = theList.Where(item => item <= limit);

            Console.WriteLine($"Resuts 2");
            foreach (var item in results2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
