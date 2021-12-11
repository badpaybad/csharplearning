using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_async_mongo.Models;

namespace Api_async_mongo.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class StudentClassesController : ControllerBase
    {
        Repo.StudentClassesRepo scr;
        public StudentClassesController()
        {
            scr = new Repo.StudentClassesRepo();
        }
        [HttpPost]
        [Route("add-studenttoclass")]
        public async Task<ApiResponse<bool>> AddStudentToClass(StudentClasses sc)
        {
            try
            {
              return await scr.AddStudentToClass(sc);
                //return new ApiResponse<bool> { Status = 1, Message = "Done", Data = true };
            }
            catch (Exception e)
            {
                return new ApiResponse<bool> { Status = 0, Message = "loi" };
            }
        }
    }
}
