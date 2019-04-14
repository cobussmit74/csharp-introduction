//DevFluence
//April 2019
//Course material: Intrucduction to C#

using System;

namespace _04_Conditional_01_LargestOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var value1 = random.Next(1000);
            var value2 = random.Next(1000);
            var value3 = random.Next(1000);

            Console.WriteLine($"Value 1 = {value1}");
            Console.WriteLine($"Value 2 = {value2}");
            Console.WriteLine($"Value 3 = {value3}");

            var largest = value1;

            if (value2 > largest) {
                largest = value2;
            }

            if (value3 > largest)
            {
                largest = value3;
            }

            Console.WriteLine($"Largest = {largest}");
            Console.ReadLine();
        }
    }
}
