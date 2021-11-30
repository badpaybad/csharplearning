using RobotCloud.CoreMongoDb;
using RobotCloud.CoreMongoDb.MNVN;
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;


namespace EntityFrameWorkJoin.MongoModels
{
   public class MongoContext : RobotCloud.CoreMongoDb.BaseMongoDbContext

    {
        //public MongoContext() : base("118.70.117.208","Thien_test1","sysadmin", "") { }

        public MongoContext() : base("localhost", "mydbname", "user", "") { }
        
        public DbSet<Student> students { get; set; }
        public DbSet<Classes> classes { get; set; }
        public DbSet<StudentClasses> studentclasses { get; set; }        
    }
}
