using RobotCloud.Core.Entities;
using RobotCloud.CoreMongoDb;
using RobotCloud.CoreMongoDb.MNVN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternRestfullApiSample.Controllers
{
    public class Student : IEntity
    {
        public Guid Id1 { get; set; }
        public string Name { get; set; }
    }
    public class ListStudent
    {
        public List<Student> Students { get; set; } = new List<Student>();
    }
    public class MongoContext : BaseMongoDbContext
    {
        public MongoContext() : base("localhost", "TestABC1", "user", "123123") { }
        public DbSet<Student> Students { get; set; }
    }
}
