using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace mathSyntax
{
    class Program
    {
        static void Main()
        {
            int num1 = 10;
            int num2 = 5;

            int total = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            int quotient = num1 / num2;

            Console.WriteLine(total);
            Console.WriteLine(difference);
            Console.WriteLine(product);
            Console.WriteLine(quotient);

            string intro = "Welcome to Drew's World! ";
            string intro2 = "Where everyone and everything is exactly what Drew likes and wants!";
            string finalIntro = intro + intro2;
            Console.WriteLine(finalIntro);
            Console.Read();


        }
    }
}
