using System;

namespace Struct
{
    class Program
    {  
           public static void Main(string[] args)
        {
            Number num = new Number();
            num.Amount = 5.2591;
            Console.WriteLine("{0}", num.Amount);
            Console.ReadLine();
        }
    }
}