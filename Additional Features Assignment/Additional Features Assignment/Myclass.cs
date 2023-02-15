using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features_Assignment
{
        class MyClass
        {
            public string MyString { get; }

            public MyClass() : this("default")
            {
            }

            public MyClass(string myString)
            {
                MyString = myString;
            }
        }

    }

