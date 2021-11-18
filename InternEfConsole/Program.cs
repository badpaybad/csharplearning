using System;
using System.Linq;

namespace InternEfConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.tektutorialshub.com/entity-framework-core/ef-core-console-application/
            Console.WriteLine("Hello World!");
            var db = new SchoolContext();

            db.Add(new Student { StudentID = Guid.NewGuid().ToString(), StudentName = "Manh" });
            db.SaveChanges();

            var students = db.Students.ToList();

            foreach(var s in students)
            {
                Console.WriteLine($"sid: {s.StudentID} , snam: {s.StudentName}");
            }

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
