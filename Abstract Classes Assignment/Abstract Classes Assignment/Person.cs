using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Abstract_Classes_Assignment
{ 
 public abstract class Person
{
    public List<string> FirstName { get; set; }
    public List<string> LastName { get; set; }
    public List<string> FullName { get; set; }


    public void ListSayName()
    {


        foreach (string name3 in FullName)
        {
            Console.WriteLine(name3);
        }




    }
}
}
