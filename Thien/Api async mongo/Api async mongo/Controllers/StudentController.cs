using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_async_mongo.Models;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Api_async_mongo.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        Models.StudentRepo sr;
            public StudentController()
        {
            sr = new StudentRepo();
        }

        [HttpPost]
        [Route("creadstudentlist")]
        public async Task< String> CreadStudent1([FromBody] ListStudent s)//json
        {

            List<Student> students = new List<Student>();
            foreach (var item in s.liststudent)
            {
                var student = new Student();
                student.Id = Guid.NewGuid();
                student.Name = item.Name;
                students.Add(student);//thêm student vào list students
            }
            var db = new Context();
            await db.Students.Collection.InsertManyAsync(students);
            return "ok";
        }

        [HttpPost]
        [Route("creadstudent")]
        public async Task<Student> CreateStudent(Student s)
        {
            return await sr.CreadStudent(s);
        }

        [Route("readstudent")]
        [HttpPost]
        public async Task<Student> ReadStudent(Student s)
        {
            return await sr.ReadStudent(s);
        }

        [Route("updatestudent")]
        [HttpPost]
        public async Task<Student> UpdateStudent(Student s)
        {
            return await sr.UpdateStudent(s);
        }

        [Route("deletestudent")]
        [HttpPost]
       public async Task<string> DeleteStudent(Student s)
        {
            return  await sr.DeleteStudent(s);
        }

    }
}
