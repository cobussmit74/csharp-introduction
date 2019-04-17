//DevFluence
//April 2019
//Course material: Introduction to C#

using System;

namespace _05_Math_02_Round
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = 3.125d;
            var roundMethod1 = Math.Round(input, 2);
            var roundMethod2 = Math.Round(input, 2, MidpointRounding.AwayFromZero);

            Console.WriteLine($"Input = {input}");
            Console.WriteLine($"Round Method 1 = {roundMethod1}");
            Console.WriteLine($"Round Method 2 = {roundMethod2}");

            Console.ReadLine();
        }
    }
}
