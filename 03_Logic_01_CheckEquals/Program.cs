//DevFluence
//April 2019
//Course material: Intrucduction to C#

using System;

namespace _03_Logic_01_CheckEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            var value1 = 123;
            var value2 = 789;

            var areTheyEqual = value1 == value2;

            Console.WriteLine($"Is {value1} equal to {value2}? {areTheyEqual}");

            value1 = 789;
            areTheyEqual = value1 == value2;

            Console.WriteLine($"Is {value1} equal to {value2}? {areTheyEqual}");
            Console.ReadLine();
        }
    }
}
