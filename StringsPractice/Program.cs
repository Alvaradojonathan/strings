using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Jonathan";
            //int lengthOfName = firstName.Length;
            //Console.WriteLine(lengthOfName);

            ////Escape characters \, 
            //string quote = "\"I'll be back.\" -Arnold";
            //Console.WriteLine(quote);

            //string escapeString = "I want a tab after this line.\t I want a new Line.\n Hi!";
            //string escapeString2 = "I want to show a backslash here \\ Hey what's that noise? \a";
            //Console.WriteLine(escapeString);
            //Console.WriteLine(escapeString2);


            //Console.WriteLine("User 1 please type something.");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("User 2 please type something.");
            //string userTwoInput = Console.ReadLine();

            ////with strings == can interchange with .Equals
            //if (userOneInput.Equals(userTwoInput))
            //{
            //    Console.WriteLine("User 2 is a copy cat!");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original!");
            //}
            //string startOfSentence = "My best friend's name is ";
            //string endOfSentence = "Joshua.";

            //Console.WriteLine(startOfSentence + endOfSentence);

            //Console.WriteLine("This is a tab\t.\nThis is a backspace \\.\nThis is a bell sound.\a");
            //Console.WriteLine("What is your first name?");
            //string fName = Console.ReadLine();
            //int fNameLength = fName.Length;

            //Console.WriteLine("What is your last name?");
            //string lName = Console.ReadLine();
            //int lNameLength = lName.Length;

            //if (fNameLength == lNameLength)
            //{
            //    Console.WriteLine("Samesis!");
            //}
            //else if (fNameLength > lNameLength)
            //{
            //    Console.WriteLine("The first name is longer.");
            //}
            //else
            //{
            //    Console.WriteLine("The last name must be longer.");
            //}

            //Comparing string equality.
            //Need to fix capitalization differences
            Console.WriteLine("First person's name:");
            string name1 = Console.ReadLine();

            Console.WriteLine("Second person's name:");
            string name2 = string.Format(Console.ReadLine());

            if (name1 == name2)
            {
                Console.WriteLine("Samesis!");
            }
            else
            {
                Console.WriteLine("The names are different.");
            }

        }
    }
}
