//DevFluence
//April 2019
//Course material: Intrucduction to C#

using System;

namespace _05_Math_01_SquarePower
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = 9;

            var root = Math.Sqrt(input);
            var power = Math.Pow(root, 3);

            Console.WriteLine($"Number = {input}");
            Console.WriteLine($"Square Root = {root}");
            Console.WriteLine($"Cubed = {power}");

            Console.ReadLine();
        }
    }
}
