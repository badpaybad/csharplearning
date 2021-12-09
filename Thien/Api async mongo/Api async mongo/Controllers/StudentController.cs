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
        [Route("creadstudent")]
        public async Task<ApiResponse<Student>> CreadStudent(Student s)
        {
            try
            {
                var student = await sr.CreadStudent(s);
                return new ApiResponse<Student> { Status = 1, Message = "Done" };
            }
            catch (Exception e)
            {
                return new ApiResponse<Student> { Status = 0, Message = "loi" };
            }
        }
        [HttpPost]
        [Route("readstudent")]
        public async Task<ApiResponse<Student>> ReadStudent(Student s)
        {
            try
            {
                var student = await sr.ReadStudent(s);
                return new ApiResponse<Student> { Status = 1, Message = "Done", Data = student };
            }
            catch (Exception e)
            {
                return new ApiResponse<Student> { Status = 0, Message = "loi" };
            }
        }

        [HttpPost]
        [Route("updatestudent")]
        public async Task<ApiResponse<Student>> UpdateStudent(Student s)
        {
            try
            {
                var student = await sr.UpdateStudent(s);
                return new ApiResponse<Student> { Status = 1, Message = "Done" };
            }
            catch (Exception e)
            {
                return new ApiResponse<Student> { Status = 0, Message = "loi" };
            }
        }

        [HttpPost]
        [Route("deletestudent")]
        public async Task<ApiResponse<string>> DeleteStudent(Student s)
        {
            try
            {
                var student = sr.DeleteStudent(s);
                return new ApiResponse<string> { Status = 1, Message = "Done" };
            }
            catch (Exception e)
            {
                return new ApiResponse<string> { Status = 0, Message = "loi" };
            }
        }
    }
}
