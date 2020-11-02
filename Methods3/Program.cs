using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please type in a second integer(optional): ");
            int num2;
            int results;
            if (int.TryParse(Console.ReadLine(), out num2))
            {
                results = math.add(num1, num2);
            }
            else
            {
                results = num1;
            }
            Console.WriteLine("The answer is " + results);
            Console.ReadLine();
        }
    }
}
 
