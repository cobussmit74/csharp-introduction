//DevFluence
//April 2019
//Course material: Introduction to C#

using System;
using static System.Math;

namespace _05_Math_01_SquarePower
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = 9;

            var root = Sqrt(input);
            var power = Pow(root, 3);

            Console.WriteLine($"Number = {input}");
            Console.WriteLine($"Square Root = {root}");
            Console.WriteLine($"Cubed = {power}");

            Console.ReadLine();
        }
    }
}
