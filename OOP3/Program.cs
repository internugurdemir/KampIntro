using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
            Console.WriteLine(numbers[0]); // prints 1
            Console.WriteLine(numbers[1]); // prints 2
            Console.WriteLine(numbers[2]); // prints 5
            Console.WriteLine(numbers[3]); // prints 7
        }
    }
}
