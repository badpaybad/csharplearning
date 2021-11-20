using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 

namespace CodefirstEF.Models
{
    public class StudentRespository
    {
        public void CreatStudent()
        {
            try
            {
                var list = new List<Student>
            {
               new Student
               {
                   Class="A",StudentId=123,StudentName="B"
               },
               new Student
               {
                   Class="B",StudentId=125,StudentName="g"
               },new Student
               {
                   Class="C",StudentId=124,StudentName="i"
               }
            };
            Console.WriteLine("Inserting a new blog");
            using (var db = new MyDbcontext())
            {
                db.Students.AddRange(list);
                db.SaveChanges();
                    Console.WriteLine($"Da insert {list.Count()} ban ghi");

                }
            }
            catch (Exception E)
            {
                Console.WriteLine($"Loi");
                return;
            }


            
              

        }
        public void GetStudentInfo(int id)
        {
            

            try
            {
                
           
                Console.WriteLine("Inserting a new blog");
                using (var db = new MyDbcontext())
                {
                    var student = db.Students.Where(x => x.StudentId == id ).FirstOrDefault();
                    if (student != null)
                    {
                        Console.WriteLine($"Hoc Sinh ten la {student.StudentName}, thuoc lop {student.Class}");
                    }
                    else
                    {
                        Console.WriteLine("khong tim thay hoc sinh");
                    }

                }
            }
            catch (Exception E)
            {
                Console.WriteLine($"Loi");
                return;
            }





        }
        public void UpdateStudent(int id, string newName, string newClass)
        {   
            try
            {
               
                using (var db = new MyDbcontext())
                {
                    var student = db.Students.Where(x => x.StudentId == id).FirstOrDefault();
                    if(student!=null)
                    {
                        student.Class = newClass;
                        student.StudentName = newName;
                        db.Students.Update(student);
                        db.SaveChanges();
                        Console.WriteLine($"ok");
                    }
                    else
                    {
                        Console.WriteLine($"Khong tim thay student");
                    }
                   

                }
            }
            catch (Exception E)
            {
                Console.WriteLine($"Loi");
                return;
            }





        }
        public void DeleteStudent()
        {
            try
            {
                var id = 124;
                using (var db = new MyDbcontext())
                {
                    var student = db.Students.Where(x => x.StudentId == id).FirstOrDefault();
                    if (student != null)
                    {
                        db.Students.Remove(student);
                        db.SaveChanges();
                        Console.WriteLine($"ok");
                    }
                    else
                    {
                        Console.WriteLine($"Khong tim thay student");
                    }


                }
            }
            catch (Exception E)
            {
                Console.WriteLine($"Loi");
                return;
            }





        }
    }
}
