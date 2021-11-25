﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver.Core.Configuration;

namespace InternEfConsole
{
    class Context : DbContext
    {
        public Context() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySQL("SERVER=localhost;database=efconsoledata;uid=root;password=710684;");
            optionsBuilder.UseMySQL("SERVER=localhost;database=efconsoledata;uid=root;password=;");

      //      modelBuilder.Entity<Participants>()
      //.HasKey(p => new { p.ActivityId, p.ParticipantId });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentClasses>()
            .HasKey(p => new {  p.ClassID, p.StudentID });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Classes> classes { get; set; }
        public DbSet<StudentClasses> studentclasses { get; set; }
    }
}
