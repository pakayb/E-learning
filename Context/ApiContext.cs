using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ELearningV2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ELearningV2.Context
{
    public class ApiContext : IdentityDbContext
    {

        public ApiContext(DbContextOptions<ApiContext> options)
        : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Part> Parts { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=elearningDB;Trusted_Connection=True");
    }
}
