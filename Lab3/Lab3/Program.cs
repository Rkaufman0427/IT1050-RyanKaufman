using System;

namespace Lab3
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Problem 
            Console.WriteLine("The If Single- Selection Statement and the While Repetition Statement are the same because they both specify and action for a result and they are different because the While Repetition Statement allows the application to repeat itself and the If Single-Selection Statment does not");

            // Problem 3
            int speedLimit;
            int speed;

            speedLimit = 35;
            speed = 42;

            if (speed > speedLimit)
            {
            Console.WriteLine("Slow Down");
            }

            // Problem 4
            //int isTrue;
            //isTrue = 1;
            bool isTrue;
            isTrue = true;

            if (isTrue)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
                Console.WriteLine("It is False!");
            }

            int a = 2;
            if (a < 5)
                Console.WriteLine("It is True");

            Console.ReadLine();
        }
    }
}
