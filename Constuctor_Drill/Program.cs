using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_var
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ClothingStore = "Fashion Barn";
            var Location = "Chicago, IL";
            Store fb259 = new Store(259, "Gold Coast");
            Store fb092 = new Store(092, "South Loop");
            Console.WriteLine("In recent news, " + ClothingStore + " will be opening 2 new locations in : " + Location + "\n" + " Store 259 in the " + fb259.location + " \n Store 092 in the " + fb092.location + "\n Thank you for all the hard work put into opening both of these beautiful locations!\n Congratulations and have a great season! \n" + "\n FASHION BARN CARES 4 YOU!");
            Console.ReadLine();
        }
    }
}