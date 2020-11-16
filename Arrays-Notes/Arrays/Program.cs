using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("Jesse");
            intList.Remove("Jesse");

            Console.WriteLine(intList[]);
            Console.ReadLine();

            byte[] byteArray = new byte[5000];
            Console.Read();
        }
        //{
        //    List<int> intList = new List<int>();
        //    intList.Add(4);
        //    intList.Add(10);

        //    Console.WriteLine(intList[10]);
        //    Console.ReadLine();
        //    \
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300};

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
    }
}
