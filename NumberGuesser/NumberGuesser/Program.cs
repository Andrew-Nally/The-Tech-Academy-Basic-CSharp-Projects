using System;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Threading;
//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    { 
        //The Number Guesser Game
        static void Main()
        {
            GetAppInfo(); //Run GetAppInfo function to get info

            GreetUser();//Ask for user name and startgame
            Console.ReadLine();

            while (true)
            {
            //Create the winning number
                Random random = new Random();
            //Random between 1-10
                int correctNumber = random.Next(1, 10);
            //default number for guess
                int guess = 0;
            //ask user for their number guess
                Console.WriteLine("Guess a number between 1 and 10");
            //create while loop to play the guessing game
                while (guess != correctNumber)
                { 
            //get user number input
                    string input = Console.ReadLine();
            //ensure the user's guess is a number
                    if (!int.TryParse(input, out guess))
                    {
            //print error message if not an actual number between 1-10
                     PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
            //keep going
                        continue;
                    }
            //cast to int and enter in user's number input
                    guess = Convert.ToInt32(input);
            //Match guess to correctNumber--if not correct
                    if (guess != correctNumber)
                    {
            //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }
            //if number is correct Print Success Message
                PrintColorMessage(ConsoleColor.Cyan, "CORRECT!");
            //Ask to play again
                Console.WriteLine("Play again? [Y or N]");
            //Get Answer
                string answer = Console.ReadLine().ToUpper();
                if( answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
            //End game
                    return;
                }
                else
                {
            //Exit Game
                    return;
                }
            }
        }
//*****************FUNCTIONS************************//
        static void GetAppInfo()
        {
            //Set App variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Andrew Nally";

            //Change Text color
            Console.ForegroundColor = ConsoleColor.Red;

            //write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset text color
            Console.ResetColor();

        }
        //Ask user name and greet
        static void GreetUser(){

            //ask for user name
            Console.WriteLine("Hello, What is your name?");

            //Get User Name
            string userName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", userName);
        }
        //print color mesage
        static void PrintColorMessage(ConsoleColor color, string message){
            Console.ForegroundColor = color;

            //TellUser must guess a NUMBER
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}
                

  