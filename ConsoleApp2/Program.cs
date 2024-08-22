using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        // this is a excerise 2
        static void Main(string[] args)
        {
            // The asks the user for their first name 
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();
            //this prints it out
           //this asks the user  for thier last name
            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();
           //this prints it out
           //this ask the user for their age 
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            //this prints it out
            // this ask for the user favorite color
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            //this combines all the strings into one sentence
            string greeting = "Hello, " + firstname + " " + lastname + "! You are " + age + " years old and your favorite color is " + color + ".";
            Console.WriteLine(greeting);
            Console.ReadLine();
            // i added Console.Readline so i can see the senctence display so it doesnt close with a second
        }
    }
}