using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalAssignment;

 class Program
{
    public static void Main(string[] args)
    {
        using (StudentDbContext db = new StudentDbContext())
        {
            var student = new Student { Name = "John Smith", Age = 20 };
            db.Students.Add(student);
            db.SaveChanges();
        }

    }
}