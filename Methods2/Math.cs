using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Math
    {
        public void Divide(int num1)
            {
                int result = num1 / 2;
                Console.WriteLine("Your number divided by 2 equals: " + result);
            }
            public void Divide(decimal num2)
            {
                int result = Convert.ToInt32(num2 * 3);
                Console.WriteLine("Your number multiplied by 3 equals: " + result);
            }
            public void Divide(string name)
            {
                int x = name.Length;
                int result = Convert.ToInt32(x + 5);
                Console.WriteLine("The number of letters in your name + 5 equals: " + result);
            }

        }
    }