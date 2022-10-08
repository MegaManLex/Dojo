using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Dojo
    {
        static void Main(string[] args)
        {
            MadLib();

            Console.ReadLine();
        }

        static void MadLib()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string name, color, pluralNoun, celebrity;


            Console.WriteLine("Hey! What's your name?...");
            name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("favorite color? :");
            color = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("What are you? :");
            pluralNoun = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("who's you're favorite celebrity? : ");
            celebrity = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Well it's nice to meet you " + name + ". \n My favorite color is actually red, not " + color + " \n I'm also an octopus not a " + pluralNoun + ". \n Why is " + celebrity + " your favorite famouse person?");
        }
    }

}

