//DevFluence
//April 2019
//Course material: Intrucduction to C#

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Lists_03_MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            var theList = new List<int> { 5, 6, 7, 33, 44, 234, 55 };

            var min = theList.First();
            var max = min;

            foreach (var item in theList)
            {
                min = Math.Min(min, item);
                max = Math.Max(max, item);
            }
            
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Maximum: {max}");
            Console.ReadLine();
        }
    }
}
