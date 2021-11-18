using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Efconsole
{
    class StudentRespository
    {
        public void AddStudent()
        {
            Console.WriteLine("Hello World!");
            var db = new StudentContext();
            db.Add(new Student { StudentID = Guid.NewGuid().ToString(), StudentName = "Manh" });

            db.SaveChanges();

            var students = db.Students.ToList();

            foreach (var s in students)
            {
                Console.WriteLine($"sid: {s.StudentID} , snam: {s.StudentName}");
            }

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
