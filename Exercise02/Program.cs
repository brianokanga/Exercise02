using Exercise01;
using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please enter the number");
            string number = Console.ReadLine();
            string results = BigIntExTension.Towards(number);
            Console.WriteLine($"{number} is {results} in words!");
        }
    }
}
