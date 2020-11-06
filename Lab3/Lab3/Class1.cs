using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class booleantest
    {
        private static bool isTrue;
        private static void Second(string[] args)
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