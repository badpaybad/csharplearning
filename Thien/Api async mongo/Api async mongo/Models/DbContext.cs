using Microsoft.EntityFrameworkCore;
using RobotCloud.CoreMongoDb.MNVN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_async_mongo.Models
{
    public class Context : BaseMongoUseObjectIdDbContext  //BaseMongoDbContext
    {
        public Context() : base("localhost", "TestApi", "user", "123123") { }
        public DbSetUseObjectId<Student> Students { get; set; }
        // public DbSet<Student> Students { get; set; }
    }
}
