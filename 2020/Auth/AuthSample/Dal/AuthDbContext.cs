using RobotCloud.Core.Entities;
using RobotCloud.CoreMongoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSample.Dal
{
    public class AuthDbContext : RobotCloud.CoreMongoDb.BaseMongoDbContext
    {
        public AuthDbContext()
            : base("localhost",
                   "SampleAuthDb",
                     "maodk",
                      "1234a@",
                      27017,
                        "",
        false)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TokenSesssion> TokenSesssions { get; set; }
        public DbSet<Acl> Acls { get; set; }
        public DbSet<UserAcl> UserAcls { get; set; }
    }

    public class TokenSesssion : IEntity
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Tokens { get; set; }

        public DateTime ExpiredAt { get; set; }
    }

    public class User : IEntity
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
    }

    public class Acl : IEntity
    {
        public Guid ParentId { get; set; }
        public string Permission { get; set; }

        public string Title { get; set; }
    }

    public class UserAcl : IEntity
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Permission { get; set; }
    }
}
