using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Boolean_Logic_CSharp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int applicantAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            int speedTix = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified:");
            bool qualified = ((applicantAge >= 15) && (dui == "NO") || (dui == "no") && speedTix <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
