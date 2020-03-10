using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolRegister.BLL.Entities;

namespace SchoolRegister.DAL.EF
{
    public class ApplicationDbContext : IdentityDbContext<User,Role,int>
    {
        private readonly ConnectionStringDto _connectionStringDto;

        public virtual DbSet<Grade> Grade { get; set; }

        public ApplicationDbContext(ConnectionStringDto connectionStringDto)
        {
            _connectionStringDto = connectionStringDto;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionStringDto.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("AspNetUsers")
                .HasDiscriminator<int>("UserType")
                .HasValue<Student>(1)
                .HasValue<Parent>(2)
                .HasValue<Teacher>(3);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SubjectGroups>()
                .HasKey(sg => new { sg.GroupId, sg.SubjectId });
            modelBuilder.Entity<SubjectGroups>()
                .HasOne(g => g.Group)
                .WithMany(sg => sg.SubjectGroups)
                .HasForeignKey(g => g.GroupId);

            modelBuilder.Entity<SubjectGroups>()
                .HasOne(s => s.Subject)
                .WithMany(sg => sg.SubjectGroups)
                .HasForeignKey(s => s.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
