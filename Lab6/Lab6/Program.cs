using System;

namespace Lab6
{
    class Program
    {
        private static int counter;

        static void Main(string[] args)
        {
            Console.WriteLine("A one-dimensional array p contains four elements. The array access expresions to the access each of the elements in p are p[0] p [1], p[2] and p[3]");



            int[] months = new int[12];
            months[0] = 1;
            months[1] = 2;
            months[2] = 3;
            months[3] = 4;
            months[4] = 5;
            months[5] = 6;
            months[6] = 7;
            months[7] = 8;
            months[8] = 9;
            months[9] = 10;
            months[10] = 11;
            months[11] = 12;
            string[] m = new string[] { "Month 1 January", "Month 2 February", "Month 3 March", "Month 4 April", "Month 5 May", "Month 6 June", "Month 7 July", "Month 8 August", "Month 9 September", "Month 10 October", "Month 11 November", "Month 12 December" };
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine(m[i]);
                Console.ReadLine();
            }
            string[] seasons = new string[] { "Winter", "Spring", "Summer", "Fall" };
            foreach (string c in seasons)
            {
                Console.WriteLine(c);
            }
            {
                {
                    Console.ReadLine();
                }

                {
                    int[] randomNumber = new int[1000];
                    Random random = new Random();
                    for (int i = 0; i < randomNumber.Length; i++)
                    { randomNumber[i] = random.Next(0, 100); }
                    foreach (int i in randomNumber)
                    {
                        Console.WriteLine(i.ToString());
                        Console.ReadLine();
                    }
                    {
                        string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
                        int i = 0;
                        while(i<names.Length)
                        { Console.WriteLine("{0,2}. {1}", i, names[i]); i++; }
                        Console.ReadLine();
                    }
                    {
                        string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
                        int i = 0;
                        foreach(string name in names)
                        { Console.WriteLine("{0,2}. {1}", i, names[i]); i++; }
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}