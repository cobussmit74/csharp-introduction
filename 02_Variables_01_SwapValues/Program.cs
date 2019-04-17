//DevFluence
//April 2019
//Course material: Introduction to C#

using System;

namespace _02_Variables_01_SwapValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var value1 = 123;
            var value2 = 789;

            Console.WriteLine($"Before Swap. Value1 = {value1} Value2 = {value2}");

            var temp = value2;
            value2 = value1;
            value1 = temp;

            Console.WriteLine($"After Swap. Value1 = {value1} Value2 = {value2}");

            Console.ReadLine();
        }
    }
}
