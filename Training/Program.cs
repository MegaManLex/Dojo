using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            string name, color, pluralNoun, celebrity;
           

            Console.WriteLine("Hey! What's your name?...");
            name = Console.ReadLine();

            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("favorite color? :");
            color = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("What are you? :");
            pluralNoun = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("who's you're favorite celebrity? : ");
            celebrity = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Well it's nice to meet you " + name + ". My favorite color is actually red, not " + color + " I'm also an octopus not a " + pluralNoun + ". Why is " + celebrity + " your favorite famouse person?");
        }
    }
}