using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Class_Obj_Drill
{
    static class Method
    {
        public static void MultiplyByFive(int input)
        {
            int answer = input * 5;
            Method.MultiplyByFive(input);

        }

        public static void AddNumbers(int input)
        {
            int answer = input + 20;
            Method.AddNumbers(input);
        }

        public static void MultiplyByTen(int input)
        {
            int answer = input * 10;
            Method.MultiplyByTen(input);
        }
    }
}
      