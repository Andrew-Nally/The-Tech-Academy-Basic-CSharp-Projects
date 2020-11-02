using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee("Same", "Person");
            Employee emp2 = new Employee("Different", "Person");
            emp2.Id = 2;

            Console.WriteLine("Emp1 and Emp2: ");
            Console.WriteLine("Result: " + Convert.ToString(emp1 == emp2));
            Console.ReadLine();
        }
    }
}