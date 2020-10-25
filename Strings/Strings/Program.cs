using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

           string firstName = "Andrew";
            string middleName = "Tyler";
            string lastName = "Nally";
           string fullName =" {firstName} + {middleName + lastName;
            Console.WriteLine(fullName);
             Console.ReadLine();
           
           string uppercase = fullName.ToUpper();
            Console.WriteLine(uppercase);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder("Hello, My name is Andrew.");
            sb.AppendLine(" I like C#.");
            sb.AppendLine("I also like The Tech Academy.");
            sb.AppendLine("My favorite color is Red.");
            sb.AppendLine("And I like to travel.");
            
            Console.WriteLine(sb);
            Console.Read();

        }
    }
}
