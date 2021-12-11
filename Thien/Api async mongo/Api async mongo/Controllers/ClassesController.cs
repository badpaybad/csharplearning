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
    public class ClassesController : ControllerBase
    {
        Repo.ClassesRepo rp;
        public ClassesController()
        {
            rp = new Repo.ClassesRepo();
        }

        [HttpPost]
        [Route("create-classes")]
       public async Task <ApiResponse<string>> CreateClasses(Classes c)//
        {
            try
            {
                var classes = await rp.CreateClasses(c);
                return new ApiResponse<string> { Status = 1, Message = "Done" };
            }
            catch (Exception e)
            {
                return new ApiResponse<string> { Status = 0, Message = "loi" };
            }
        }
        [HttpPost]
        [Route("read-classes")]
        public async Task<ApiResponse<Classes>> ReadClasses(Classes c)
        {
            try
            {
                var classes = await rp.ReadClasses(c);
                return new ApiResponse<Classes> {Status = 1, Message = "Done", Data = classes };
            }
            catch (Exception e)
            {
                return new ApiResponse<Classes> { Status = 0, Message = "loi" };
            }
        }

        [HttpPost]
        [Route("update-classes")]
        public async Task<ApiResponse<string>>UpdateClasses(Classes c)
        {
            try
            {
                var classes = await rp.UpdateClasses(c);
                return new ApiResponse<string> { Status = 1, Message = "Done" };
            }
            catch (Exception)
            {
                return new ApiResponse<string> { Status = 0, Message = "loi" };
            }
        }
        [HttpPost]
        [Route("delete-Classes")]
        public async Task<ApiResponse<string>> DeleteClasses(Classes c)
        {
            try
            {
                var classes =await rp.DeleteClasses(c);
                return new ApiResponse<string> { Status = 1, Message = "Done" };
            }
            catch (Exception e)
            {
                return new ApiResponse<string> { Status = 0, Message = "loi" };
            }
        }
    }
}
 