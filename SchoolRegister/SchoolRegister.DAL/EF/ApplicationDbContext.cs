using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolRegister.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.DAL.EF
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int>
    {
        private readonly ConnectionStringDto _connectionStringDto; // connection string
        // Table properties e.g
        public virtual DbSet<Grade> Grade { get; set; }
        // other table properties
        // ……
        //public DbSet<Post> Posts { get; set; } // example table property
        //public DbSet<Comment> Comments { get; set; }
        public ApplicationDbContext(ConnectionStringDto connectionStringDto) // constructor
        {
            _connectionStringDto = connectionStringDto;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionStringDto.ConnectionString); // for provider SQL Server 
    }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Fluent API commands
            modelBuilder.Entity<User>() // defining a one to many relation in fluent API
                        .ToTable("AspNetUsers")
                        .HasDiscriminator<int>("UserType")
                        .HasValue<Student>(1)
                        .HasValue<Parent>(2)
                        .HasValue<Teacher>(3);
        }
    }
}
