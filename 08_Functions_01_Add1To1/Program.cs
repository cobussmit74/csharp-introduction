using System;

namespace _08_Functions_01_Add1To1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Add1To1();
            Console.WriteLine($"{result}");
            Console.ReadLine();
        }

        static int Add1To1()
        {
            return 1 + 1;
        }
    }
}
