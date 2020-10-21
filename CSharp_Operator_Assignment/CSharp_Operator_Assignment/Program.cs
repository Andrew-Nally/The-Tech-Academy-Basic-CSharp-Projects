using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Operator_Assignment
{
    class Program
    {
        static void Main()
        {
            //Take input from user, multiply by 50 and print to the console
            Console.WriteLine("Please enter a number...");
            ulong userNumber = Convert.ToUInt64(Console.ReadLine());
            string userNum = userNumber.ToString();
            Console.WriteLine(userNum + " multiplied by 50 equals " + userNumber * 50);
            Console.ReadLine();

            //Take user input and add 25
            Console.WriteLine("Please enter a number...");
            int userNumber1 = Convert.ToInt32(Console.ReadLine());
            int userNum1 = userNumber1 + 25;
            string plus25 = userNumber1.ToString();
            Console.WriteLine(plus25 + " plus 25 equals " + userNum1);
            Console.ReadLine();

            //Takes user input and divides it by 12.5
            Console.WriteLine("Please enter a number...");
            double userNumber2 = Convert.ToDouble(Console.ReadLine());
            double userNum2 = userNumber2 / 12.5;
            string divNum = userNumber2.ToString();
            Console.WriteLine(divNum + " divided by 12.5 equals " + userNum2);
            Console.ReadLine();

            //Takes user input and checks if greater than 50
            Console.WriteLine("Please enter a number...");
            int userNumber3 = Convert.ToInt32(Console.ReadLine());
            string userNum3 =  userNumber3.ToString();
            Console.WriteLine("is " + userNum3 + "  greater than 50?");
            Console.ReadLine();
            bool greaterNum =  userNumber3 > 50;
            Console.WriteLine(greaterNum);
            Console.ReadLine();

            //Takes input from user and divides it by 7, prints remainder
            Console.WriteLine("Please enter a number...");
            double userNumber4 = Convert.ToDouble(Console.ReadLine());
            double userNum4 = userNumber4 % 7;
            string modNum = userNum4.ToString();
            Console.WriteLine(modNum + " is the remainder of " + userNumber4 + " divided by 7");
            Console.ReadLine();




        }
    }
}
