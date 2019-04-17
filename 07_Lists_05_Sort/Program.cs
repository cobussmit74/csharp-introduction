//DevFluence
//April 2019
//Course material: Introduction to C#

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Lists_05_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var theList = new List<int> { 10,9,8,7,6,5,4,3,2,1 };
            
            var orderedList = theList.OrderBy(i => i);
            foreach (var item in orderedList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
