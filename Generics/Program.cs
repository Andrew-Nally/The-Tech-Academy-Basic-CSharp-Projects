using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeesStr = new Employee<string>();
            employeesStr.things = new List<string>();
            employeesStr.things.Add("Kenny");
            employeesStr.things.Add("Jarrod");


            Employee<int> employeesInt = new Employee<int>();
            employeesInt.things = new List<int>();
            employeesInt.things.Add(001);
            employeesInt.things.Add(002);

            foreach (var str in employeesStr.things)
                Console.WriteLine("{0}", str);


            foreach (int integer in employeesInt.things)
                Console.WriteLine("{0}", integer);

            Console.ReadLine();
        }
    }
}
