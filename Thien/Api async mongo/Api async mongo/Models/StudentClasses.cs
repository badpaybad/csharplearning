using RobotCloud.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_async_mongo.Models
{
    public class StudentClasses : IEntity
    {
        public Guid IdStudent { get; set; }
        public Guid IdClasses { get; set; }
    }
}
