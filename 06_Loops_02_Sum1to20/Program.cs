//DevFluence
//April 2019
//Course material: Introduction to C#

using System;

namespace _06_Loops_02_Sum1to20
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = 0;
            var count = 20;
            for (var x = 1; x <= count; x++)
            {
                total += x;
            }

            var averageInt = total / count;
            var averageDouble = total / (count * 1d);

            Console.WriteLine($"Total = {total}");
            Console.WriteLine($"Average (Int) = {averageInt}");
            Console.WriteLine($"Average (Double) = {averageDouble}");

            Console.ReadLine();
        }
    }
}
