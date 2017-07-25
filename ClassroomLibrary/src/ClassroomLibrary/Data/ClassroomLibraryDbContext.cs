using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassroomLibrary.Models;


namespace ClassroomLibrary.Data
{
    public class ClassroomLibraryDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserLibrary> UserLibrary { get; set; }
        public DbSet<Category> Categories { get; set; }


        public ClassroomLibraryDbContext(DbContextOptions<ClassroomLibraryDbContext> options)
           : base(options)
        { }

        public ClassroomLibraryDbContext() { }

     protected override void OnModelCreating(ModelBuilder modelBuilder)
     {
            modelBuilder.Entity<User>()
            .HasKey(c => new { c.ID, c.Username });
          }
        


    }
}
