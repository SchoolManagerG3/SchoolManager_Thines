using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace SchoolManagerApp.Models
{
    public class SchoolManagerContext : DbContext
    {
        public DbSet<Class> Classes { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Administrator> Administrators { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>().ToTable("Classes");

            modelBuilder.Entity<Course>().ToTable("Courses");

            modelBuilder.Entity<Student>().ToTable("Students");

            modelBuilder.Entity<Teacher>().ToTable("Teachers");

            modelBuilder.Entity<Administrator>().ToTable("Administrators");

        }


    }
}
