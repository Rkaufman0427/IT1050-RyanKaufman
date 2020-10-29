using System;

namespace Lab2
{
    class Addition
    {
        //Main method begins execution of C# app
        static void Main()
        {
            int number1 = 15;
            int number2 = 12;
            int sum = number1+number2;

            Console.Write("Enter first integer:15 ");
            int v = int.Parse(Console.ReadLine());
            number1 = v;

            Console.Write("Enter second integer:12");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine("Sum is, 27");
        }
    }
}
