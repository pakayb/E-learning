using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ELearningV2.Models;

namespace ELearningV2.Context
{
    public class ApiContext : DbContext
    {

        //public ApiContext(DbContextOptions<ApiContext> options)
        //: base(options)
        //{
        //}
        public DbSet<User> Users { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Logged> ActiveUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=elearning.db");
    }
}
