using System;

namespace Lab2
{
    class Addition
    {
        public static void Main(string[] args)
        {
            int number1;
            int number2;
            int sum;

            Console.WriteLine("Enter first integer:");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second integer:");
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine("Sum is {0}",sum);
        }
    }
}
