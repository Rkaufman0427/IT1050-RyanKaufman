using System;

namespace Lab3
{
    public class Driving
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The If Single- Selection Statement and the While Repetition Statement are the same because they both specify and action for a result and they are different because the While Repetition Statement allows the application to repeat itself and the If Single-Selection Statment does not");

            int speedLimit = 35;
            int speed = 42;
            if (speed > speedLimit)
            {
             Console.WriteLine("Slow Down");
            }
             Console.ReadLine();

        }
    }
}
    public class booleantest
    {
            private static bool isTrue;
            private static void Main(string[]args)
            {
            bool user = isTrue;
            if (user == isTrue)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
                Console.WriteLine("It is False!");
        }
        }
    }
}
