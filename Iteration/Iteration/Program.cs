using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main()
        {
            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 95 };

            for (int i = 0; i <= testScores.Length; i++)
            {
                if (testScores[i] => 85)
                {
                  int testScores =  Convert.ToBoolean( Console.ReadLine())
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
                Console.ReadLine();
            }

            String[] names = { "jesse", "Erik", "Daniel", "Adam" };

            for (int j = 0; j <= names.Length; j++)
            {
                if (names[j] == "jesse")
                {
                    Console.WriteLine(names[j]);
                }
                Console.ReadLine();
            }
        }
    }
}

