using MongoDB.Bson;
using RobotCloud.Core.Entities;
using RobotCloud.CoreMongoDb.MNVN;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameWorkJoin.MongoModels
{
    public class StudentClasses: IEntity
    {
      
        public Guid StudentId { get; set; }

        public Guid  ClassId { get; set; }
    }
}
