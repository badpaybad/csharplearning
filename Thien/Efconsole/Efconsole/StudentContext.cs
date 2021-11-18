using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Efconsole
{
    public class StudentContext : DbContext
    {
        public StudentContext()
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Server=localhost;Database=csharpsample;Uid=root;Pwd=710684;");
        }
        public DbSet<Student> Students { get; set; }
    }
}