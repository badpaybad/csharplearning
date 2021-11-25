using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace InternEfConsole
{
    class ClassesRepository
    {
       public bool AddStudentToClass(string IdClass,string IdStudent)
        {          
                using (var db = new Context())
                {
                    var classes = db.classes.Where(i => i.ClassID == IdClass).FirstOrDefault();
                    var student = db.students.Where(i => i.StudentID == IdStudent).FirstOrDefault();
                    if(classes != null && student !=null)
                    {
                        db.Add(new StudentClasses { ClassID = IdClass, StudentID = IdStudent });
                        db.SaveChanges();
                        return true;
                    }    
                    else
                    {                    
                    return false;
                    }                        
                }                      
        }
        public bool DeleteStudentinClass(string IdClass, string IdStudent)
        {
            using(var db = new Context())
            {
                var classes = db.classes.Where(i => i.ClassID == IdClass).FirstOrDefault();
                var student = db.students.Where(i => i.StudentID == IdStudent).FirstOrDefault();
                if(classes != null && student != null)
                {
                    var deletestudent = db.studentclasses.Where(i => i.ClassID == IdClass && i.StudentID == IdStudent).FirstOrDefault();
                    db.studentclasses.Remove(deletestudent);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }    

        }
        public void SelectStudentsInClass(string IdClass)//lay hoc sinh theo lop
        {                                                   //lỗi
            using(var db = new Context())
            {
                var ListStudents = db.students.ToList();
                var ListClasses = db.classes.ToList();
                var ListStudentClasses = db.studentclasses.ToList();
                var kq = from sc in ListStudentClasses
                         join s in ListStudents on sc.StudentID equals s.StudentID
                         join cl in ListClasses on sc.ClassID equals cl.ClassID
                         select new
                         {
                             StudentName = s.StudentName,
                             ClassName = cl.ClassName
                         };
                foreach (var a in kq)
                {
                    Console.WriteLine($"ClassName: {a.ClassName}, StudentName: {a.StudentName}");
                }


            }
        }
    }
}
