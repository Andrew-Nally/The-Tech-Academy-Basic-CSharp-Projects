
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_TryCatch
{
    public class AgeException : Exception
    {
        public AgeException()
           : base() { }
        public AgeException(String message)
            : base(message) { }
    }
}