using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 15;
            int number2 = 12;
            int sum = 27;

            Console.Write("Enter first integer:15");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer:12");
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine("Sum is, 27");
        }
    }
}
