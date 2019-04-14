//DevFluence
//April 2019
//Course material: Intrucduction to C#

using System;

namespace _06_Loops_01_Print1To10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var x = 1; x <= 10; x++)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
