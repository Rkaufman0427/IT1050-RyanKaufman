using System;

namespace Lab2
{
    class Program
    {
        public static void Main(string[] args )
        {
            int number1 = 15;
            int number2 = 12;
            int sum = 27;

            Console.Write("Enter first integer:15"); // prompt user// read first number from user
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer:12"); // prompt user// read second number from user
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine("Sum is, 27");
        }
    }
}
