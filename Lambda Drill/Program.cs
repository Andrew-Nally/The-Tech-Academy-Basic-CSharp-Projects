
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Drill
{

    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()


        {
                new Employee(){Id = 1, FirstName= "Jarrod", LastName= "Smith"},
                new Employee(){Id = 2, FirstName= "Kenny", LastName= "Bartell"},
                new Employee(){Id = 3, FirstName= "Jacob", LastName= "Leather"},
                new Employee(){Id = 4, FirstName= "TJ", LastName= "Smyser"},
                new Employee(){Id = 5, FirstName= "Matt", LastName= "Mayday"},
                new Employee(){Id = 6, FirstName= "Drew", LastName= "Tyler"},
                new Employee(){Id = 7, FirstName= "Mo", LastName= "Moe"},
                new Employee(){Id = 8, FirstName= "Joe", LastName= "Blank"},
                new Employee(){Id = 9, FirstName= "Joe", LastName= "Blanks"},
                new Employee(){Id = 10, FirstName= "David", LastName= "MoMo"},
            };




            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    List<string> newList = new List<string>();
                    newList.Add(employee.FirstName + " " + employee.LastName + " " + employee.Id);
                    newList.ForEach(Console.WriteLine);


                }

            }
            Console.ReadLine();



            List<Employee> employees1 = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee employee1 in employees1)
            {
                Console.WriteLine(employee1.FirstName + " " + employee1.LastName + " " + employee1.Id);
            }
            Console.ReadLine();


            List<Employee> employees2 = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee employee2 in employees2)
            {
                Console.WriteLine(employee2.FirstName + " " + employee2.LastName + " " + employee2.Id);
            }

            Console.ReadLine();



        }





    }
}


