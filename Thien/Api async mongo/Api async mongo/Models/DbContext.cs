using RobotCloud.Core.Entities;
using RobotCloud.CoreMongoDb;
using RobotCloud.CoreMongoDb.MNVN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_async_mongo.Models
{
    public class Context : BaseMongoDbContext
    {
        public Context() : base("localhost", "TestApi2", "user", "123123") { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Classes> Classess { get; set; }
        public DbSet<StudentClasses> StudentClassess { get; set; }
    }
}
