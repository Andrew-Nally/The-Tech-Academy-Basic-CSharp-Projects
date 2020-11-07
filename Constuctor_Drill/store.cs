using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_var
{
    class Store
    {
        public int id;
        public string location;
        public Store() : this(0, "") { }
        public Store(int id, string location)
        {
            this.id = id;
            this.location = location;
        }
        public Store(int id) : this(id, "") { }
        public Store(string location) : this(0, location) { }
    }
}