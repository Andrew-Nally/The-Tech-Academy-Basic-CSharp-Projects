using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Output_Params
{
    class Math
         {
            public void mathApp(int num1) 
        {
            int results1 = num1 / 2;
            Console.WriteLine(num1 + " / 2 = " + results1);
        }

        public static void mathApp(int num2, int num3, out int times, out int div)
        {
            times = num2 * num3;
            div = (num2 / num3);
        }

    }
}

