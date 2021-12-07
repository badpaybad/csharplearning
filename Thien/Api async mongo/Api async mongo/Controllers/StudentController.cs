using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_async_mongo.Models;
using MongoDB.Driver;
using Microsoft.EntityFrameworkCore;

namespace Api_async_mongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        [Route("create-student")]
        public async Task<IEnumerable<string>> CreadStudent([FromBody] Student s)//json
        {
            try
            {
                using (var db = new Context())
                {
                    var student = new Student();
                    student.Id = Guid.NewGuid();
                    student.Name = s.Name;
                    await db.Students.Collection.InsertOneAsync(student);
                    return new List<string>() { student.Id.ToString(), student.Name };
                }
            }
            catch (Exception)
            {
                return null;
            }           
        }

        [HttpPost]
        [Route("create-liststudent")]
        public async Task<string> ListStudent([FromBody] ListStudent s)
        {
            List<Student> students = new List<Student>();
            foreach(var item in s.liststudent)
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

        [HttpPost]
        [Route("read-student")]
        public async Task<IEnumerable<string>> ReadStudent([FromBody] Student s)
        {
            try
            {
                using (var db = new Context())
                {
                    var student = await db.Students.Where(i => i.Id == s.Id).FirstOrDefaultAsync();
                    return new List<string> { s.Id.ToString(), s.Name };
                }
            }
            catch (Exception)
            {
                return null;
            }

        }

        [HttpPost]
        [Route("update-student")]
        public async Task<IEnumerable<string>> UpdateStudent([FromBody ]Student s)
        {
            try
            {
                using (var db = new Context())
                {
                    var student = await db.Students.Where(i => i.Id == s.Id).FirstOrDefaultAsync();
                    student.Name = s.Name;
                    return new List<string> { s.Id.ToString(), s.Name };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [Route("delete-student")]
        public async Task<string> DeleteStudent([FromBody]Student s)
        {
            try
            {
                using (var db = new Context())
                {
                    var student = await db.Students.Where(i => i.Id == s.Id).FirstOrDefaultAsync();
                    await db.Students.Delete(student);
                    return "ok";
                }
            }
            catch (Exception)
            {
                return "false";
            }
        }

    }
}
