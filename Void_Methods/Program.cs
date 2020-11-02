using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Digits number = new Digits();
                number.DigitMethods(3, 92);
                int a = 9;
                int b = 72;
                number.DigitMethods(a, b);
            }
        }
    }
}

