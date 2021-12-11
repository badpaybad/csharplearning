using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_async_mongo.Models;
//using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Api_async_mongo.Repo
{
    public class StudentClassesRepo
    {
        public async Task<ApiResponse<bool>> AddStudentToClass(StudentClasses sc)
        {
            try
            {
                using (var db = new Context())
                {
                    var student = await db.Students.Where(i => i.Id == sc.IdStudent).FirstOrDefaultAsync();
                    var classes = await db.Classess.Where(i => i.Id == sc.IdClasses).FirstOrDefaultAsync();
                    if (student != null && classes != null)
                    {
                        var addtoclass = new StudentClasses();
                        addtoclass.IdStudent = sc.IdStudent;
                        addtoclass.IdClasses = sc.IdClasses;

                        var checknull = await db.StudentClassess.Where(i => i.IdClasses == sc.IdClasses && i.IdStudent == sc.IdStudent).FirstOrDefaultAsync();
                        if (checknull == null)
                        {
                            await db.StudentClassess.Collection.InsertOneAsync(addtoclass);
                            return new ApiResponse<bool> { Status = 1, Message = "Done", Data = true };
                        }
                        //await db.StudentClassess.Collection.InsertOneAsync(new StudentClasses { IdStudent = sc.IdStudent, IdClasses = sc.IdClasses });
                    }
                    return new ApiResponse<bool> { Status = 0, Message = "loi" };
                }
            }
            catch (Exception e)
            {
                return new ApiResponse<bool> { Status = 0, Message = "loi" }; ;
            }
        }
    }
}
