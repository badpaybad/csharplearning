using RobotCloud.Core.Entities;
using RobotCloud.CoreMongoDb;
using RobotCloud.CoreMongoDb.MNVN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_async_mongo.Models
{
    public class Student : IEntity 
    {
       //public Guid Id { get; set; }
        public string Name { get; set; }
  
    }
    public class ListStudent
    {
        public List<Student> liststudent { get; set; } = new List<Student>();
    }
}
