using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_IQuttable
{
    class Program
    {
        static void Main(string[] args)
      
            {
                IQuittable quit = new Employee("Sample", "Student");
                quit.Quit();
            }
        }
    }
