using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Api_async_mongo.Models
{
    public class StudentRepo
    {
        public async Task<Student> CreadStudent( Student s)
        {
            //var student = new Student { Id1 = Guid.NewGuid(), Name = s.Name };
            var student = new Student();
            student.Id = Guid.NewGuid();
            student.Name = s.Name;

            var db = new Context();
            await db.Students.Insert(student);
            //return new List<string>() { student.Id.ToString(), student.Name };
            return student; 
        }

        public async Task<string> CreadStudentList( ListStudent s)
        {

            List<Student> students = new List<Student>();
            foreach (var item in s.StudentList)
            {
                var student = new Student();
                student.Id = Guid.NewGuid();
                student.Name = item.Name;
                students.Add(student);
            }
            var db = new Context();
            await db.Students.Collection.InsertManyAsync(students);
            return "ok";
        }
        public async Task<Student> ReadStudent( Student s)
        {
            var db = new Context();
            var student = await db.Students.Where(i => i.Id == s.Id).FirstOrDefaultAsync();
            return student;

        }
        public async Task<Student> UpdateStudent( Student s)
        {
            var db = new Context();
            var student = await db.Students.Where(i => i.Id == s.Id).FirstOrDefaultAsync();
            student.Name = s.Name;
            await db.Students.Update(student);
            return student;
        }
        public async Task<string> DeleteStudent(Student s) 
        {
            var db = new Context();
            var student = await db.Students.Where(i => i.Id == s.Id).FirstOrDefaultAsync();
            await db.Students.Delete(student);
            return "Done";

        }
    }
}
