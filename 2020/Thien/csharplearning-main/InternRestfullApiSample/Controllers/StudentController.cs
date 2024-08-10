using InternRestfullApiSample.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternRestfullApiSample.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        [Route("creadstudent1")]
        public String CreadStudent1([FromBody] ListStudent s)//json
        {
             List<Student> students = new List<Student>();
             foreach(var item in s.Students)
             {
                 var student = new Student();
                 student.Id1 = Guid.NewGuid();
                 student.Name = item.Name;
                 students.Add(student);
             }

             var db = new MongoContext();
             db.Students.Collection.InsertMany(students);
             return "ok";
        }

        [HttpPost]
        [Route("creadstudent")]
        public IEnumerable<string> CreadStudent([FromBody] Student s)//json
            {
                //var student = new Student { Id1 = Guid.NewGuid(), Name = s.Name };
            var student = new Student();
            student.Id1 = Guid.NewGuid();
            student.Name = s.Name;

            var db = new MongoContext();
            db.Students.Insert(student);
            return new List<string>() { student.Id1.ToString(), student.Name };
        }
        

        /*[Route("readstudent")]
        [HttpPost]
        public IEnumerable<string> ReadStudent([FromBody]Student s) //post json
        {
            var db = new MongoContext();
            var student = db.Students.Where(i => i.Id1 == s.Id1).FirstOrDefault();                  
            return new List<string> { student.Id1.ToString() , student.Name};
        }*/
        [Route("readstudent")]
        [HttpGet]
        public IEnumerable<string> ReadStudent(Guid s)//get json
        {
            var db = new MongoContext();
            var student = db.Students.Where(i => i.Id1 == s ).FirstOrDefault();
            return new List<string> { student.Id1.ToString(), student.Name };
        }

        [Route("updatestudent")]
        [HttpPost]
        public IEnumerable<string> UpdateStudent([FromBody]Student s)//post json
        {
            var db = new MongoContext();
            var student = db.Students.Where(i => i.Id1 == s.Id1).FirstOrDefault();
            student.Name = s.Name;
            db.Students.Update(student);
            return new List<string> { student.Id.ToString(), student.Name };          
        }

        [Route("deletestudent")]
        [HttpPost]
        public IEnumerable<string> DeleteStudent([FromBody]Student s)
        {
            var db = new MongoContext();
            var student = db.Students.Where(i => i.Id1 == s.Id1).FirstOrDefault();
            db.Students.Delete(student);
            return new List<string> { "ok"};
            
        }
    }


    
    
}
