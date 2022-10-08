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
            

            Console.ReadLine();
        }


        //Created accessible, and executable program that can be called under the main function. In this case, "MadLibs();".
        static void MadLib()
        {
            //made multiple additions to the text color of each question using the ForegroundColor change command
            Console.ForegroundColor = ConsoleColor.Green;

            string name, color, pluralNoun, celebrity;

            //Telling VS to print questions to the user
            Console.WriteLine("Hey! What's your name?...");
            //User inputs various forms of personal data.
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
            //Final input for VS to respond to the user using print that I placed. Extra lines added to improve readability. 
            Console.WriteLine(" Well it's nice to meet you " + name + ". \n My favorite color is actually red, not " + color + " \n I'm also an octopus not a " + pluralNoun + ". \n Why is " + celebrity + " your favorite famouse person?");
        }
    }

}

