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
        public DbSet<Book> Book { get; set; }
        public DbSet<Category> Categories { get; set; }


        public ClassroomLibraryDbContext(DbContextOptions<ClassroomLibraryDbContext> options)
           : base(options)
        { }

        public ClassroomLibraryDbContext() { }

     protected override void OnModelCreating(ModelBuilder modelBuilder)
     {
          //  modelBuilder.Entity<User>()
         //  .HasMany(c => c.UserBooks).WithOne(i => i.User);

          //  modelBuilder.Entity<Book>()
          // .HasKey(c => new { c.ID, c.IdOfUser });

          }
        


    }
}
