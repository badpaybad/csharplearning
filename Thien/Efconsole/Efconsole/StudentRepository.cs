using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Efconsole
{
    class StudentRespository
    {
        public void CreateStudent(string NameStudent)   //them hoc sinh theo ten
        {
            var db = new StudentContext();
            db.Add(new Student { StudentID = Guid.NewGuid().ToString(), StudentName = NameStudent });
            db.SaveChanges();

            /*  //in ra toàn bộ data
            var students = db.Students.ToList();//db.Students.ToList() select data chuyển thành kiểu List

            foreach (var s in students)                                            
            {
                Console.WriteLine($"sId: {s.StudentID} , sName: {s.StudentName}");   
            }
            */

            Console.WriteLine("Done!");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        public void ReadStudent(string id)  //lay hoc sinh theo id
        {
            var db = new StudentContext();
            var students = db.Students.Where(i => i.StudentID == id);
            foreach(var s in students)
            {
                Console.WriteLine("sId: " + s.StudentID +"  sName: " +s.StudentName);
                // Console.WriteLine($"sId: {s.StudentID} , sName: {s.StudentName}");
                
            }
            Console.WriteLine("Done!");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        
        public void UpdateStudent(string id, string name)   //cap nhat ten hoc sinh theo id
        {
            var db = new StudentContext();

            var students= db.Students.Where(i => i.StudentID == id).FirstOrDefault();//????
            students.StudentName = name;
            db.SaveChanges();
            Console.WriteLine("Done!");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        public void DeleteStudent(string id)    //xoa hoc sinh theo id
        {
            var db = new StudentContext();
            var students = db.Students.Where(i => i.StudentID == id).FirstOrDefault();
            db.Students.Remove(students);
            db.SaveChanges();
            Console.WriteLine("Done!");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        
       
    }
}
