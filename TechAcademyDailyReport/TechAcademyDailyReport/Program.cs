using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyDR
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.Read();

            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine();
            

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
        

            Console.WriteLine("What page number?");
            int pageNumber = pageNumber.ToString();
            Console.ReadLine();
            
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            bool courseHelp = Console.ReadLine();
            courseHelp.ToString();
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you would like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you would like to share?");
            bool feedback = Console.ReadLine();
            feedback.ToString();
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Console.ReadLine();
            hoursStudied.ToString();
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        } 
    }
}
