using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ClassroomLibrary.Data;

namespace ClassroomLibrary.Migrations
{
    [DbContext(typeof(ClassroomLibraryDbContext))]
    [Migration("20170807003338_ABC")]
    partial class ABC
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClassroomLibrary.Models.Book", b =>
                {
                    b.Property<int>("ID");

                    b.Property<int>("IdOfUser");

                    b.Property<string>("AuthorFName");

                    b.Property<string>("AuthorLName");

                    b.Property<int>("BookLevel");

                    b.Property<int?>("CategoryID");

                    b.Property<string>("Genre");

                    b.Property<int?>("ThisUserID");

                    b.Property<string>("Title");

                    b.HasKey("ID", "IdOfUser");

                    b.HasIndex("CategoryID");

                    b.HasIndex("ThisUserID");

                    b.ToTable("Book");
                });

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
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FullName");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ClassroomLibrary.Models.Book", b =>
                {
                    b.HasOne("ClassroomLibrary.Models.Category", "Category")
                        .WithMany("UserLibraries")
                        .HasForeignKey("CategoryID");

                    b.HasOne("ClassroomLibrary.Models.User", "ThisUser")
                        .WithMany("UserBooks")
                        .HasForeignKey("ThisUserID");
                });
        }
    }
}
