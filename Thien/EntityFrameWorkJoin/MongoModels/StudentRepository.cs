using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq;



namespace EntityFrameWorkJoin.MongoModels
{
    public class StudentRepository    
    {
        public bool Create(string NameStudent)
        {
            try
            {
                using (var db = new MongoContext())
                {
                    db.students.Collection.InsertOne(new Student { StudentId = Guid.NewGuid(), StudentName = NameStudent });

                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Read(Guid StudentId)  
        {
            var db = new MongoContext();
            var student = db.students.Where(i => i.StudentId == StudentId).FirstOrDefault();
            if (student != null)
            {
                Console.WriteLine($"sId: {student.StudentId} , sName: {student.StudentName}");
                return true;
            }
            else
            {             
                return false;              
            }

        }
        public bool Update(Guid IdStudent, string NameStudent)   
        {
            var db = new MongoContext();
            var student = db.students.Where(i => i.StudentId == IdStudent).FirstOrDefault();

            if (student != null)
            {
                student.StudentName = NameStudent;
                db.students.Update(student);
                return true;
            }
            return false;
        }
        public bool DeleteStudent(Guid id)    
        {
            var db = new MongoContext();
            var students = db.students.Where(i => i.StudentId == id).FirstOrDefault();
            if (students != null)
            {
                db.students.Delete(students);
                return true;
            }
            return false;
        }
    }
}
