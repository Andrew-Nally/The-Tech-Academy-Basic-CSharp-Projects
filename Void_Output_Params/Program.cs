using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Output_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.Write("enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            math.mathApp(num);

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter one more number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Math.mathApp(num2, num3, out int times, out int div);

            Console.WriteLine(num2 + " x " + num3 + " = " + times);
            Console.WriteLine(num2 + " / " + num3 + " = " + div);
            Console.ReadLine();

        }
    }
}
