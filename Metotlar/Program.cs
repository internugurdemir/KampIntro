using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2(10,10,10);


            int number1 = 20, number2 = 100;
            var result2 = Add3(out number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            //Console.WriteLine(Add4(1,2,3,4,5,6));

            Console.ReadLine();
        }
        static void Add() { Console.WriteLine("Add,,,"); }
        static int Add2(int x=40,int number1=50, int number2=10)
        {
            var result = number1 + number2+x;
            return result;
        }
        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1+number2;
        }
        //static int Add4(int number1,params int[] numbers)
        //{
        //    //return numbers.Sum();
        //}
    }
}
