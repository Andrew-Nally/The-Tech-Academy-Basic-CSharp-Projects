using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace TA_Iteration_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] oneDArray = { " one", " two", " three", " four ", " five" };
            Console.WriteLine("Type a word to add to the end of 5 strings... ");

            string input = Console.ReadLine();

            for (int i = 0; i < oneDArray.Length; i++)
                oneDArray[i] = oneDArray[i] + input;
            for (int i = 0; i < oneDArray.Length; i++)
                Console.WriteLine("[" + i + "]" + oneDArray[i]);
            Console.ReadLine();

            //======================================================//
            //for (int i = 1; i > 0; i++)
            //{
            //    Console.WriteLine("This is the string that never ends! It goes on and on my friend :)");
            //}
            //Console.ReadLine();

            //========================================================//
            for (int i = 0; i < 5; i++)
                Console.WriteLine("[" + i + "]" + "Compares using the < operator");
            Console.ReadLine();
            //========================================================//
            for (int i = 0; i <= 5; i++)
                Console.WriteLine("[" + i + "]" + "Compares using the <= operator");
            Console.ReadLine();
            //===========================================================//

            List<string> stringList = new List<string>();
            stringList.Add("one");
            stringList.Add("two");
            stringList.Add("three");
            stringList.Add("four");
            stringList.Add("five");

            Console.WriteLine("Search for a word: ");
            input = Console.ReadLine();

            bool match = false;
            for (int i = 0; i < stringList.Count; i++)
                if (stringList[i].Equals(input))
                {
                    match = true;
                    Console.WriteLine(" Found string at index [" + i + "]:" + stringList[i]);
                    break;
                }
            if (!match)
                Console.WriteLine("Not found.");
            Console.ReadLine();

            //================================================================//
            int count = 0;
            match = false;
            List<string> stringList2 = new List<string>();
            stringList2.Add("string1");
            stringList2.Add("string1");
            stringList2.Add("string2");
            stringList2.Add("string2");
            stringList2.Add("string3");
            stringList2.Add("string4");
            stringList2.Add("string5");

            Console.WriteLine("Search List of strings: ");
            input = Console.ReadLine();
            Console.WriteLine(input);
            foreach (string s in stringList2)
            {
                if (s.Equals(input))
                {
                    match = true;
                    Console.WriteLine(count);
                }
                count++;
            }
            if (!match)
                Console.WriteLine("Not Found");
            Console.ReadLine();
            //=============================================================//
            match = false;
            List<string> repeats = new List<string>();
            stringList2 = new List<string>();
            stringList2.Add("string1");
            stringList2.Add("string1");
            stringList2.Add("string2");
            stringList2.Add("string3");
            stringList2.Add("string4");
            stringList2.Add("string5");

            Console.WriteLine("String|Repeat?");
            foreach (string s in stringList2)
            {
                foreach (string inner in repeats)
                    if (inner.Equals(s))
                        match = true;
                Console.WriteLine(s + " | " + match);
                Console.ReadLine();
                repeats.Add(s);
                match = false;
            }
            Console.ReadLine();
        }
    }
}