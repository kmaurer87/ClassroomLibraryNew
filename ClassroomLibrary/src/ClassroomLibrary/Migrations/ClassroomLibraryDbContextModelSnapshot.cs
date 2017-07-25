using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ClassroomLibrary.Data;

namespace ClassroomLibrary.Migrations
{
    [DbContext(typeof(ClassroomLibraryDbContext))]
    partial class ClassroomLibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClassroomLibrary.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ClassroomLibrary.Models.User", b =>
                {
                    b.Property<int>("ID");

                    b.Property<string>("Username");

                    b.Property<string>("Email");

                    b.Property<string>("FullName");

                    b.Property<string>("Password");

                    b.HasKey("ID", "Username");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ClassroomLibrary.Models.UserLibrary", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorFName");

                    b.Property<string>("AuthorLName");

                    b.Property<int>("BookLevel");

                    b.Property<int?>("CategoryID");

                    b.Property<string>("Genre");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("UserLibrary");
                });

            modelBuilder.Entity("ClassroomLibrary.Models.UserLibrary", b =>
                {
                    b.HasOne("ClassroomLibrary.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");
                });
        }
    }
}
