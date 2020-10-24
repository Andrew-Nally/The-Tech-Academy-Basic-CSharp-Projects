using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            int count = 0;
            while (count <= 5)
            {
                Console.WriteLine("The total = " + count);
                count++;

                Console.ReadLine();

            }
            int count2 = 0;
            do
            {
                Console.WriteLine("Loopy");
                count2++;
            }
            while (count2 <= 4);
            Console.ReadLine();
        }
    }
}