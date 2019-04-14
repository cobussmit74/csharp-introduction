//DevFluence
//April 2019
//Course material: Intrucduction to C#

using System;

namespace _03_Logic_02_CheckEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = 5;

            var isItEven = value % 2 == 0;
            Console.WriteLine($"Is {value} even? {isItEven}");

            value++; isItEven = value % 2 == 0;
            Console.WriteLine($"Is {value} even? {isItEven}");

            Console.ReadLine();

        }
    }
}
