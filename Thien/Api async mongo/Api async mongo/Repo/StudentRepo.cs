using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Api_async_mongo.Models;

namespace Api_async_mongo.Repo
{
    public class StudentRepo
    {
        public async Task<ApiResponse<bool>> CreadStudent( Student s)
        {
            try
            {
                using (var db = new Context())
                {
                    var student = new Student();
                    student.Id = Guid.NewGuid();
                    student.NameStudent = s.NameStudent;
                    await db.Students.Collection.InsertOneAsync(student);
                    //return new List<string>() { student.Id.ToString(), student.Name };
                    return new ApiResponse<bool> { Status = 1, Message = "thêm thành công", Data = true };
                }                   
            }
            catch (Exception)
            {
                return new ApiResponse<bool> { Status = 0, Message = "có lỗi xảy ra", Data = false };
            }           
        }

        public async Task<bool> CreadStudentList( ListStudent s)
        {
            try
            {
                List<Student> students = new List<Student>();
                foreach (var item in s.StudentList)
                {
                    var student = new Student();
                    student.Id = Guid.NewGuid();
                    student.NameStudent = item.NameStudent;
                    students.Add(student);
                }
                var db = new Context();
                await db.Students.Collection.InsertManyAsync(students);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
        public async Task<Student> ReadStudent( Student s)
        {
            try
            {
                var db = new Context();
                var student = await db.Students.Where(i => i.Id == s.Id).FirstOrDefaultAsync();
                return student;
            }
            catch (Exception e)
            {
                return null;
            }
           

        }
        public async Task<bool> UpdateStudent( Student s)
        {
            try
            {
                using(var db = new Context())
                {
                    var student = await db.Students.Where(i => i.Id == s.Id).FirstOrDefaultAsync();
                    if (student == null)
                    {
                        return false;
                    }
                    student.NameStudent = s.NameStudent;                   
                    await db.Students.Update(student);
                    return true;
                }    
            }
            catch (Exception e)
            {
                return false;
            }                      
        }
        public async Task<bool> DeleteStudent(Student s) 
        {
            try
            {
                var db = new Context();
                var student = await db.Students.Where(i => i.Id == s.Id).FirstOrDefaultAsync();
                if (student == null)
                {
                    return false;
                }
                await db.Students.Delete(student);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
    }
}
