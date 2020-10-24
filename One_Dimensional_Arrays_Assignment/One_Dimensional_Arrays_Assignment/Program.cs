using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Dimensional_Arrays_Assignment
{
    class Program
    {
        static void Main() {
        //====Array of Strings======//
            string[] stringArray = { "red", "blue", "green", "yellow", "black", "pink", "white", "gold", "silver" };
            Console.WriteLine("Pick a number from 1 to 9: ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i >= 0 && i <= 9)
            {
                Console.WriteLine("You picked the color " + stringArray[i - 1]);
             }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            Console.ReadLine();

            //=======Array of Integer=====/
            int[] intArray = { 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            Console.WriteLine("Pick a number from 1 to 9: ");
            int j = Convert.ToInt32(Console.ReadLine());
            if (j >= 0 && j < 10)
            {
                Console.WriteLine("The number you chose at index " + j + " is " + intArray[j - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }

            Console.ReadLine();

            //====List Of Strings=====//
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Tiger");
            listOfStrings.Add("Lion");
            listOfStrings.Add("Bear");
            listOfStrings.Add("Wolf");
            listOfStrings.Add("Cheetah");
            listOfStrings.Add("Fox");
            listOfStrings.Add("Snake");
            listOfStrings.Add("Horse");
            listOfStrings.Add("Frog");

            Console.WriteLine("\n Pick a number between 1 and 9...");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k >= 0 && k < 9)
            {
                Console.WriteLine("You chose the : " + listOfStrings[k - 1]);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            Console.ReadLine();
        }
    }
}
