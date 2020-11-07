using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime rightNow = DateTime.Now;
            Console.WriteLine("It is currently: " + rightNow);

            Console.WriteLine("\nEnter a whole number:");
            var userNum = Convert.ToInt32(Console.ReadLine());

            rightNow = rightNow.AddHours(userNum);
            Console.WriteLine("\nIn {0} hours it will be: {1}.", userNum, rightNow);
            Console.ReadLine();
        }
    }
}