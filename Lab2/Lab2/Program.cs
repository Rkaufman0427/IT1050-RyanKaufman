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

            Console.WriteLine("Sum is {0}", sum);
    
            Console.WriteLine("{0}\n{1}", "Hello World!", "From Ryan Kaufman");

            Console.WriteLine("Hello World! From Ryan Kaufman");

            Console.WriteLine("A. At what point in our program does our C# Console Applications execute?, It would be the main entry point"):
            Console.WriteLine("B. What is the difference between an integer type variable and a double / floating-point variable?, The Differance is that Integer Type are whole number and Double/Floating-point variables are decimals.");
            Console.WriteLine("C. We can create blocks of code that we can call by name using a method.  Give an example of a method from Chapter 4., an example of a Method is SetName");
            Console.WriteLine("D. Like we have types double and int, we can create our own custom types using Classes.  Each class has variables called instance variables or class members.  To read the value of an instance variable, we create method called a GET accessor.  To assign a value ton instance variable, we use a method called a SET accessor.");
            Console.WriteLine("E. What is the difference between a class and an object?  How many instances of a class can we create (please explain your answer)?")
        }
    }
}
