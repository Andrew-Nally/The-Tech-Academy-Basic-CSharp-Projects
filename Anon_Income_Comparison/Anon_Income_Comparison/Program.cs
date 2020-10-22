using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anon_Income_Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("What is Person1's hourly pay?");
            int p1_hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours per week does Person1 work?");
            int p1_hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("What is Person2's hourly pay?");
            int p2_hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours per week does Person2 work?");
            int p2_hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual Salary of Person 1: ");
            Console.ReadLine();
            int p1_income = (p1_hourly * p1_hours) * 52;
            Console.WriteLine(p1_income);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2: ");
            Console.ReadLine();
            int p2_income = (p2_hourly * p2_hours) * 52;
            Console.WriteLine(p2_income);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool biggerIncome = p1_income > p2_income;
            Console.WriteLine(biggerIncome);
            Console.ReadLine();

         }
    }
}
