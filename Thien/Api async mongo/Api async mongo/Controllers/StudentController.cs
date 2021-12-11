using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_async_mongo.Repo;
using Api_async_mongo.Models;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Api_async_mongo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        Repo.StudentRepo sr;
        public StudentController()
        {
            sr = new StudentRepo();
        }

        [HttpPost]
        [Route("creadstudent")]
        public async Task<ApiResponse<bool>> CreadStudent(Student s)
        {
            try
            {
                /* var student = await sr.CreadStudent(s);

                 if (student.Status == 1)
                 {
                     return new ApiResponse<Student> { Status = 1, Message = student.Message };
                 }
                 else
                 {
                     return new ApiResponse<Student> { Status = 0, Message = student.Message };
                 }*/
                return await sr.CreadStudent(s);
            }
            catch (Exception e)
            {
                return new ApiResponse<bool> { Status = 0, Message = "có lỗi xảy ra", Data = false };
            }
        }

        [HttpPost]
        [Route("creadstudentlist")]
        public async Task<ApiResponse<bool>> CreadStudentList(ListStudent s)
        {
            try
            {
                var crlist = await sr.CreadStudentList(s);
                if (crlist == true)
                {
                    return new ApiResponse<bool> { Status = 1, Message = "thêm thành công", Data = true };
                }
                else
                {
                    return new ApiResponse<bool> { Status = 1, Message = "có lỗi xảy ra", Data = false };
                }

            }
            catch (Exception e)
            {
                return new ApiResponse<bool> { Status = 0, Message = "có lỗi xảy ra", Data = false };
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
                return new ApiResponse<Student> { Status = 0, Message = "loi", Data = null };

            }
        }

        [HttpPost]
        [Route("updatestudent")]
        public async Task<ApiResponse<bool>> UpdateStudent(Student s)
        {
            try
            {
                var student = await sr.UpdateStudent(s);
                if(student == false)
                {
                    return new ApiResponse<bool> { Status = 0, Message = "có lỗi xảy ra", Data = false };
                }
                return new ApiResponse<bool> { Status = 1, Message = "update thành công", Data = true };
            }
            catch (Exception e)
            {
                return new ApiResponse<bool> { Status = 0, Message = "có lỗi xảy ra", Data = false };
            }
        }

        [HttpPost]
        [Route("deletestudent")]
        public async Task<ApiResponse<bool>> DeleteStudent(Student s)
        {
            try
            {
                var student = await sr.DeleteStudent(s);
                if(student == false)
                {
                    return new ApiResponse<bool> { Status = 0, Message = "có lỗi xảy ra", Data = false };
                }    
                return new ApiResponse<bool> { Status = 1, Message = "xóa thành công", Data = true };
            }
            catch (Exception e)
            {
                return new ApiResponse<bool> { Status = 0, Message = "có lỗi xảy ra" , Data = false };
            }
        }
    }
}
