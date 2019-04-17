//DevFluence
//April 2019
//Course material: Introduction to C#

using System;
using System.Collections.Generic;

namespace _07_Lists_02_DoubleAllItems
{
    class Program
    {
        static void Main(string[] args)
        {
            var theList = new List<int> { 5, 6, 7, 33, 44, 234, 55 };
            
            Console.WriteLine("Original Values");
            foreach (var item in theList)
            {
                Console.WriteLine(item);
            }

            for (var index = 0; index < theList.Count; index++)
            {
                theList[index] = theList[index] * 2;
            };

            Console.WriteLine("Doubled Values");
            foreach (var item in theList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
