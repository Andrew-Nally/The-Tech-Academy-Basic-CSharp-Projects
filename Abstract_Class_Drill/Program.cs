using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee per = new Employee();
            per.firstName = "Sample";
            per.lastName = "Student";
            per.SayName();
            Console.ReadLine();
        }
    }
}
