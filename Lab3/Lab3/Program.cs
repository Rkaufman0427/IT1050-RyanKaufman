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

            Console.WriteLine("Input temperature in Fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double celcius = (fahrenheit - 32d) * 5d / 9d;
            Console.WriteLine("Temperature in Celcius is {0}:", celcius);
            if (fahrenheit >= 90)
                Console.WriteLine("It is hot");
            if (fahrenheit <= 40)
                Console.WriteLine("It is cold");

            int x = 1;
            while (x<11)
            {
                Console.WriteLine(x); x++;
            }

            int y = 60;
            while (y>20)
            {
                Console.WriteLine(y); y--;
            }
            int z = 10;
            while (z<=20)
            {
                Console.WriteLine(z); z++;
            }

            Console.ReadLine();
        }
    }
}
