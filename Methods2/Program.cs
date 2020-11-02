using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {        
                Math math = new Math();
                Console.WriteLine("Enter a whole number: ");
                math.Divide(Convert.ToInt32(Console.ReadLine()));
                Console.ReadLine();

                math = new Math();
                Console.WriteLine("Enter a decimal number: ");
                math.Divide(Convert.ToDecimal(Console.ReadLine()));
                Console.ReadLine();

                math = new Math();
                Console.WriteLine("Enter Your Name: ");
                math.Divide(Convert.ToString(Console.ReadLine()));
                Console.ReadLine();

            }
        }
    }
