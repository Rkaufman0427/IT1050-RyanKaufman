using System;

namespace Lab3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The If Single- Selection Statement and the While Repetition Statement are the same because they both specify and action for a result and they are different because the While Repetition Statement allows the application to repeat itself and the If Single-Selection Statment does not");

            string speedLimit = Console.ReadLine();
            string speed = Console.ReadLine();

            string message = "";

            if (speedLimit == "35")
            {
                message = "";
                Console.WriteLine(message);
            }
            else if (speed == "42")
            {
                message = "SLOW NOW!";
                Console.WriteLine(message);
            }
            Console.ReadLine();
        }
    }
}
