using System;

namespace Lab3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The If Single- Selection Statement and the While Repetition Statement are the same because they both specify and action for a result and they are different because the While Repetition Statement allows the application to repeat itself and the If Single-Selection Statment does not");

            int speedLimit;
            int speed;

            speedLimit = 35;
            speed = 42;

            if (speed > speedLimit)
            {
            Console.WriteLine("Slow Down");
            }

        }
    }
}
