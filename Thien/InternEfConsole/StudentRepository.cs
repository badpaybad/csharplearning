using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace InternEfConsole
{
    class ExceptionStudentNotValid : Exception
    {

    }
    class StudentRepository
    {
        public bool CreateStudent(string IdStudent, string NameStudent)//them hoc sinh
        {
            try
            {
                using (var db = new Context())
                {
                    db.Add(new Student { StudentID = IdStudent, StudentName = NameStudent });
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        public bool ReadStudent(string IdStudent) //in ra hoc sinh
        {
            using (var db = new Context())
            {
                var student = db.students.Where(i => i.StudentID == IdStudent).FirstOrDefault();
                if (student != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool UpdateStudent(string IdStudent, string NameStudent) //updata ten hoc sinh
        {
            try
            {
                using (var db = new Context())
                {
                    var student = db.students.Where(i => i.StudentID == IdStudent).FirstOrDefault();
                    if (student != null)
                    {
                        student.StudentName = NameStudent;
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("loi");
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool DeleteStudent(string IdStudent)//xoa hoc sinh
        {
            try
            {
                using (var db = new Context())
                {
                    var student = db.students.Where(i => i.StudentID == IdStudent).FirstOrDefault();
                    db.students.Remove(student);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
