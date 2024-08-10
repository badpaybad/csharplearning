using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternEfConsole
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //https://www.connectionstrings.com/mysql/
            // pwd laf mat khau luc cai dat mysql, 
            optionsBuilder.UseMySQL(@"Server=localhost;Database=csharpsample;Uid=root;Pwd=;");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Classes> Classes { get; set; }
    }


}
