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
            Console.ReadLine();
            string myName = "Drew";
            Console.ReadLine();
            Console.WriteLine(myName);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            Console.ReadLine();
            string courseName = "C#";
            Console.WriteLine(courseName);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            Console.ReadLine();
            int pageNumber = 133;
            pageNumber.ToString();
            Console.WriteLine(pageNumber);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            Console.ReadLine();
            bool courseHelp = false;
            courseHelp.ToString();
            Console.WriteLine(courseHelp);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you would like to share? Please give specifics.");
            Console.ReadLine();
            string positiveExperience = "I totally appreciate the thorough explanations of all the C# terminology, concepts, etc. It totally helped clarify all the things I didnt understand the first time around making it so much more fun to learn";
            Console.WriteLine(positiveExperience);
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you would like to share?");
            Console.ReadLine();
            bool feedback = false;
            feedback.ToString();
            Console.WriteLine(feedback);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            Console.ReadLine();
            int hoursStudied = 10;
            hoursStudied.ToString();
            Console.WriteLine(hoursStudied);
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        } 
    }
}
