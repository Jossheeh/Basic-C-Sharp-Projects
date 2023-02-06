using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Assignment
{

    public class Employee : Person, IQuittable
    {
        public void SayName()
        {
            throw new NotImplementedException();
        }
        public void Quit(Person person)
        {
            throw new NotImplementedException();
        }
    }
}

