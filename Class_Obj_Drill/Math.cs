using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Class_Obj_Drill
{
    class Math
    { 
        public void Multiply(int num1)
        {
            int result = num1 * 5;
            Console.WriteLine("Your number multiplied by 5 equals: " + result);
        }
        public void Addition(int num1)
        {
            int result = num1 + 5;
            Console.WriteLine("Your number plus 5 equals: " + result);
        }
        public void Divide(int num1)
        {
            int result = num1 / 5;
            Console.WriteLine("Your number divided by 5 equals: " + result);
        }
    }
}