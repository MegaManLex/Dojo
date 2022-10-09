namespace Training
{
    class Dojo
    {
        static void Main()
        {
            //use the space on this specific comment to call either FizzBuzz(); Calculator(); BubbleSort(); or MadLib(); 
            Console.ReadLine();
        }
        //Created executible function that can be used in the Main Function Comment space, in this case "BubbleSort();" .
        static void BubbleSort()
        {
            //Changing color scheme to suit bubble title
            Console.ForegroundColor = ConsoleColor.Blue;
            //simple header
            Console.WriteLine("\n BubbleSort Time! \n");
            //introducing an array of random numbers
            int[] arr = { 4, 6, 1, 67, 345, 3, 34, 512, 342, 251 };
            //using a loop with a subtraction to stay within the boundaries of the array, and not go outside of it.
            for (int i = 0; i < arr.Length - 1; i++)
            {
                //using a positional loop to keep variables side by side
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    //this -if- statment will be used to organize, and determine which interger is larger, or smaller
                    if (arr[j] > arr[j + 1])
                    {//defining data, and positionals
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            //loop made to scan the array to check if everything was executed correctly
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        //created accessible, and executible function that can be used in the Main Function via Call. In this case "FizzBuzz();"
        static void FizzBuzz()
        {
            //created for loop to define the number data type, and add singular increments to allow for the loop to continue until it hits 100.
            for (int num = 1; num <= 100; num++)
                //if a number in this array is divisible by both 5 and 3 then we will get a combination of verbiage.
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
            // if the nubmer in the array is divisible by 3 then we will get a single word from the resulted analization
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
            //if the number is divisible by 5 we will see a variant of the verbiage that was previously displayed
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(num);
                }

        }

        //created accessible, and executible function that can be used in the Main Function. In this case "Calculator();"
        static void Calculator()
        {
            //Decorative header to introduce the operation.
            Console.WriteLine("vvvvvvvvvvvvvvv");
            Console.WriteLine("Calculator!");
            Console.WriteLine("^^^^^^^^^^^^^^");

            //defining data types used
            double num1;
            double num2;
            double result;

            //organizing foreground colors for easier readability for User Input
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Give me a number! : ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Give me a second number : ");
            num2 = Convert.ToDouble(Console.ReadLine());

            //Introducing several common operators
            Console.WriteLine("Type in an operator : ");
            Console.WriteLine("+ to add");
            Console.WriteLine("- to subtract");
            Console.WriteLine("* to multiply");
            Console.WriteLine("/ to divide");

            //initiating various protocals depending on user input
            Console.ForegroundColor=ConsoleColor.Magenta;
            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Adds up to... : {num1} + {num2} = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Subtracts to... : {num1} - {num2} = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Should multiply to... : {num1} * {num2} = " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Splits into... : {num1} / {num2} = " + result);
                    break;

                    //Using default text in case someone inputs certain shenanigans 
                default:
                    Console.WriteLine("That's not a thing...");
                    break;
            }

        }

        //Created accessible, and executable program that can be called under the main function. In this case, "MadLibs();".
        static void MadLib()
        {
            //made multiple additions to the text color of each question using the ForegroundColor change command
            Console.ForegroundColor = ConsoleColor.Green;

            string name, color, pluralNoun, celebrity;

            //Decorative text to introduce the function
            Console.WriteLine("vvvvvvvvvvvvvvv");
            Console.WriteLine("Small MadLibs!");
            Console.WriteLine("^^^^^^^^^^^^^^");

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