using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodefirstEF.Models
{
    public class MyDbcontext : DbContext
    {
        public MyDbcontext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Server=localhost;Database=themanh127;Uid=root;Pwd=12071999;");
        }
        public DbSet<Student>Students{ get; set; }
    }
}
