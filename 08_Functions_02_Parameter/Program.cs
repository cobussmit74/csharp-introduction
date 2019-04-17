//DevFluence
//April 2019
//Course material: Introduction to C#

using System;

namespace _08_Functions_02_Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = Add1(10);
            var result2 = Add1(55);
            var result3 = Add1(100);
            Console.WriteLine($"{result1}");
            Console.WriteLine($"{result2}");
            Console.WriteLine($"{result3}");
            Console.ReadLine();
        }

        static int Add1(int value)
        {
            return value + 1;
        }
    }
}
