//DevFluence
//April 2019
//Course material: Introduction to C#

using System;
using System.Collections.Generic;

namespace _07_Lists_01_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            var theList = new List<int>();
            Console.WriteLine($"Items in list = {theList.Count}");

            for (var x = 1; x <= 10; x++)
            {
                theList.Add(x);
            }

            Console.WriteLine($"Items in list = {theList.Count}");
            Console.ReadLine();
        }
    }
}
