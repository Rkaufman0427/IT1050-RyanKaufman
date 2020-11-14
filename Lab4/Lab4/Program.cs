using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Elements are 1. a control variable or loop counter. 2. The control variables initial value. 3. The control variables increment thats applied during each iteration of the loop. 4. the loop-continuation condition that determines if looping should continue.");

            Console.WriteLine("The while iteration statement the app tests the loop-continuation condition at the beginning of the loop, before executing the loops body. If the condition is false the body never executes. The For statement is where the initialization expression names the loops control variable and provides initial value, the loopcontinuationcondition determines whether looping should continue and the increment modifies the control variables value so that the loop-continuation condition eventually becomes false");

            Console.WriteLine("The While, for and foreach statements preform the action or group of actions in their bodies zero or more times-if the loop continuation condition is initially falze, the action or group of actions will not execute. The Do While preforms the action of group of actions in its body one or more times. The words if, else, switch, while, do, for and foreach are C# keywords.");

            Console.WriteLine("Please enter a temperature");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input <= 10)
            {
                Console.WriteLine("Polar Bear");
            }
            else if (input <= 20)
            {
                Console.WriteLine("Penguin");
            }
            else if (input <= 40)
            {
                Console.WriteLine("Moose");
            }
            else if (input <= 50)
            {
                Console.WriteLine("Reindeer");
            }
            else if (input <= 60)
            {
                Console.WriteLine("Deer");
            }
            else if (input <= 70)
            {
                Console.WriteLine("Turtle");
            }
            else if (input <= 80)
            {
                Console.WriteLine("Lion");
            }
            else if (input <= 90)
            {
                Console.WriteLine("Fish");
            }
            else
            {
                Console.WriteLine("Bug");

                int i = 0;
                do
                {
                    Console.WriteLine(i); i++;
                    Console.WriteLine("********");
                }
                while (i < 101);

                Console.ReadLine();
            }
        }
    }
}
