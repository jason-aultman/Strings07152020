using System;
using System.Globalization;
using System.Xml;

namespace Strings07152020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatination
            Console.WriteLine("My name " + "is " + "Jason"); 
            var somethingFunky = string.Concat("Hi", " im", " Jason");
            Console.WriteLine(somethingFunky);
            Console.WriteLine($"{somethingFunky} the best dude");

            //Split
            var stringToManipulate = "This is a string that we need to split, ok?";
            var stringThatsSplit = stringToManipulate.Split(',');
            for (int i=0;i<stringThatsSplit.Length;i++)
            {
                Console.WriteLine(stringThatsSplit[i]);
            }

            //Whitespace
            string whitespace = "   there is    a   bunch of   whitespace    here.";
            Console.WriteLine(whitespace.Trim());
            Console.WriteLine(whitespace.Replace("  ", " "));
            Console.WriteLine(whitespace.Replace(" ", ""));

            //IndexOf
            var multiTeacher = "Cory Darion Jason";
            var firstIndex = multiTeacher.IndexOf("Jason");
            var secondIndex = multiTeacher.IndexOf("Darion");
            Console.WriteLine($"The first index of Jason is {firstIndex}");
            Console.WriteLine($"The first index of Darion is {secondIndex}");

            //StringComparison.
            var userInput = Console.ReadLine();
            if (userInput.Equals("KORI", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Hey it does equal!!!!");
            }

        }
    }
}
