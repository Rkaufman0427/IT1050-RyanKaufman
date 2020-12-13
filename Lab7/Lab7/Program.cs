using System;

namespace Lab7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book Info Example");
        }
        public string authorfirstName { get; private set; }
        public string authorlastName { get; private set; }
        public string Title { get; private set; }
        public string datePublishYear { get; private set; }

        public Book(string authorfirstName, string authorlastName, string Title, string datePublishYear)
        {
            authorfirstName = "J.R.R.";
            authorlastName = "Tolkein";
            Title = "The Lord of the Rings";
            datePublishYear = "1954";
        }
        public override string ToString()
        {
            return string.Format("Author:, Title:, Published, firstName, lastName, Title, datePublishYear");
        }
        class BookTest
        {
            public static void Main(string[] args)
        }
        var author = new Author("J.R.R. Tolkein");
        var title = new Title("The Lord of the Rings");
        var publish year = new /Publish year("1954");
        BookTest Information = new Book("The Lord of the Rings,"J.R.R.Tolkein,"1954");

        Console.WriteLine("information");
        {
        }

            Console.WriteLine("Question 3,CLR is what is caled before adding a constructor");
            Console.WriteLine("Question 4, The concept of Overloading would be used");
            Console.WriteLine("Question 5, So fault tolerant programs can resolve exceptions");
            Console.WriteLine("Question 6, The purpose of private vs. public when adding new properties is so that it can hide implementations from clients. Public can be seen, used and accessed by any emthod whereas private is nly used when called and needed.");
            Console.WriteLine("Question 7, Composition is when classes have the capability to have references to objects of other class members. Known as the Has-A relationships");
            Console.WrtieLine("Questions 8, Data Abstraction is when a client cares about what the class offers and the funtionality is implemented");

    }
}