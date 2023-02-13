using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{

    class Employee<T>
    {
        public List<T> Things { get; set; }

        public Employee(List<T> things)
        {
            Things = things;
        }
    }

}

